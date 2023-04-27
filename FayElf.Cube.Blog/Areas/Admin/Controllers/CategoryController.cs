using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XiaoFeng.Mvc;
using FayElf.Blog.Model;
using XiaoFeng;
namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 分类管理
    /// </summary>
    [AdminMenu("分类管理","系统管理", "zw-icon zw-icon-category2", 2)]
    public class CategoryController : AdminEntityController<ZWTbCategoryModel>
    {
        #region 首页
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        [AdminAuthorize(PermissionFlags.Detail)]
        public override IActionResult List()
        {
            PageData.Title = "分类管理";
            PageData.Pages = this.GetPages();
            PageData.Page = this.GetListPage();
            return View();
        }
        #endregion

        #region 更新分类排序
        /// <summary>
        /// 更新分类排序
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="SortID">排序值</param>
        /// <returns></returns>
        [HttpPost]
        [AdminAuthorize(PermissionFlags.Update)]
        public JsonContent UpdateSortID(int ID, int SortID)
        {
            if (ID == 0) return JsonError("参数出错.");
            var model = ZWTbCategoryModel.Create.Find(a => a.ID == ID);
            if (model == null) return JsonError("您所修改的数据不存在.");
            model.SortID = SortID;
            return Operate(model, a => a.Update(), "更新分类排序");
        }
        #endregion

        #region 更新分类状态
        /// <summary>
        /// 更新分类状态
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="Pass">状态</param>
        /// <returns></returns>
        [HttpPost]
        [AdminAuthorize(PermissionFlags.Update)]
        public JsonContent SetPass(int ID, Boolean Pass)
        {
            if (ID == 0) return JsonError("设置分类状态失败");
            var category = this.Entity.Find(a => a.ID == ID);
            if (category == null) return JsonError("当前分类不存在");
            category.Pass = Pass.ToCast<short>();
            return this.Operate(category, a => a.Update(), "设置分类状态");
        }
        #endregion

        #region 重写添加
        /// <summary>
        /// 重写添加
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AdminAuthorize(PermissionFlags.Insert)]
        public override IActionResult Add()
        {
            var ParentID = this.Value<int>("ID");
            var model = new ZWTbCategoryModel { ParentID = ParentID }; 
            var page = this.GetAddPage();
            page.Fields.Field.Each(f =>
            {
                if (f.Name == "ParentID") return;
                if (f.DefaultValue.IsNotNullOrEmpty())
                    model[f.Name] = f.DefaultValue;
            });
            this.PageData.Data = model;
            return base.Add();
        }
        #endregion
    }
}