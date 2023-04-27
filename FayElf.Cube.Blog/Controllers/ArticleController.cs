using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;
using XiaoFeng.Data.SQL;

namespace FayElf.Cube.Blog.Controllers
{
    /// <summary>
    /// 技术文章
    /// </summary>
    public class ArticleController : EntityController<ZWTbBlogModel>
    {
        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public override IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 目录列表
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        [HttpGet("/Article/List/{ID:long}")]
        public IActionResult List(long ID)
        {
            var cata = ZWTbCatalogueModel.Create.Find(a => a.ID == ID);
            if (cata == null) return Redirect("/");
            PageData.Add("knowledge", ZWTbKnowledgeModel.Create.Find(a => a.ID == cata.KnowledgeID));
            PageData.Add("catalogueID", ID);
            PageData.Add("catalogueName", cata.Name);
            return View();
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        [HttpGet("/Article/{ID:regex(^[[a-z0-9]]{{32}}$)}")]
        public IActionResult Info(string ID)
        {
            var id = ID.ToCast<Guid>().ToString("D").ToUpper();
            var info = VIEWBlogModel.Create.Find(a => a.ID == id);
            ZWTbBlogModel.Create.QueryableX.Update(a =>a.Hits == a.Hits.AddSQL(1), b => b.ID == info.ID);
            if(info == null) return Redirect("/");
            PageData.Add("knowledge", ZWTbKnowledgeModel.Create.Find(a => a.ID == info.KnowledgeID));
            PageData.Add("catalogueID", info.CatalogueID);
            PageData.Add("catalogueName", info.CatalogueName);
            return View(info);
        }
        /// <summary>
        /// 提交评论
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="nickname">昵称</param>
        /// <param name="qq">qq</param>
        /// <param name="email">email</param>
        /// <param name="msg">评论</param>
        /// <returns></returns>
        [HttpPost("/Article/{ID:regex(^[[a-z0-9]]{{32}}$)}")]
        public JsonContent Info(string ID,[FromForm]string nickname, [FromForm] string qq, [FromForm] string email, [FromForm] string msg)
        {
            if (nickname.IsNullOrEmpty()) return JsonError("请输入您的姓名.");
            if (msg.IsNullOrEmpty()) return JsonError("请输入您的评论.");

            return new ZWTbCommentModel
            {
                ID = Guid.NewGuid().ToString("D").ToUpper(),
                BlogID = ID.ToCast<Guid>().ToString("D").ToUpper(),
                Email = email,
                QQ = qq,
                UserName = nickname,
                Pass = 0,
                UserIP = this.Request.UserIpv4Address(),
                Content = msg
            }.Insert() ? JsonOK() : JsonError("评论失败.");
        }
    }
}
