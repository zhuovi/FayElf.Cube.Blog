using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XiaoFeng.Mvc;
using FayElf.Blog.Model;
namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 单页管理
    /// </summary>
    [AdminMenu("单页管理", "内容管理", "zw-icon zw-icon-set3", 3)]
    public class PublicHtmlController : AdminEntityController<ZWTbPublichtmlModel>
    {
        /// <summary>
        /// 重写主页
        /// </summary>
        /// <returns></returns>
        public override IActionResult Index()
        {
            PageData.Pages = this.GetPages();
            PageData.Page = this.GetEditPage();
            var list = ZWTbCategoryModel.Create.Where(a => a.Attribute == 3).ToList();
            PageData.Add("CategoryList", list);
            var ID = this.Value<int>("ID");
            var category = list.Find(a => a.ID == ID);
            PageData.Add("CategoryName", category == null ? "单页管理" : category.Name);
            PageData.Title = (category == null ? "" : category.Name + "-") + "单页管理";
            PageData.Add("ID", category == null ? "" : ID.ToString());
            if (ID > 0 && category != null)
            {
                var html = ZWTbPublichtmlModel.Create.Find(a => a.CategoryID == ID);
                if (html == null) html = new ZWTbPublichtmlModel { CategoryID = ID, Title = category.Name };
                PageData.Data = html;
            }
            return View();
        }
        /// <summary>
        /// 更新单页数据
        /// </summary>
        /// <param name="model">数据</param>
        /// <returns></returns>
        [HttpPost]
        public JsonContent Index(ZWTbPublichtmlModel model)
        {
            if (model.ID.GetValueOrDefault() == 0)
                return base.Add(model);
            else
                return base.Edit(model);
        }
    }
}