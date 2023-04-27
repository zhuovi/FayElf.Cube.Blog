using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;

namespace FayElf.Cube.Blog.Controllers
{
    /// <summary>
    /// 单页
    /// </summary>
    public class PublicHtmlController : EntityController<ZWTbPublichtmlModel>
    {
        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public override IActionResult Index()
        {
            return Redirect("/");
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        [HttpGet("/PublicHtml/{ID:long}")]
        public IActionResult Info(long ID)
        {
            var html = ZWTbPublichtmlModel.Create.Find(a => a.CategoryID == ID);
            if (html == null)
                return Error("数据不存在.", "url:/");
            return View(html);
        }
    }
}
