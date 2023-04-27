using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;

namespace FayElf.Cube.Blog.Controllers
{
    public class KnowledgeController : EntityController<ZWTbKnowledgeModel>
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public override IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 知识库
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        [HttpGet("/Knowledge/{ID:long}")]
        public IActionResult Info(Int64 ID)
        {
            var know = ZWTbKnowledgeModel.Create.Find(a=>a.ID== ID);
            this.PageData["knowledge"] = know;
            this.PageData["knowledgeID"] = ID;
            this.PageData["knowledgeName"] = know.Title;
            return View();
        }
    }
}
