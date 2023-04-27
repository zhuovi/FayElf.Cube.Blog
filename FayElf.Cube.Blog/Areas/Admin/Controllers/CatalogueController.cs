using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;

namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 目录
    /// </summary>
    [AdminMenu("目录管理", "博客管理", "zw-icon zw-icon-catalogue2", 2)]
    public class CatalogueController : AdminEntityController<VIEWCatalogueModel>
    {
        #region 更新目录排序
        /// <summary>
        /// 更新目录排序
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="SortID">排序值</param>
        /// <returns></returns>
        [HttpPost]
        [AdminAuthorize(PermissionFlags.Update)]
        public JsonContent UpdateSortID(int ID, int SortID)
        {
            if (ID == 0) return JsonError("参数出错.");
            var model = ZWTbCatalogueModel.Create.Find(a => a.ID == ID);
            if (model == null) return JsonError("您所修改的数据不存在.");
            model.SortID = SortID;
            return Operate(model, a => a.Update(), "更新目录排序");
        }
        #endregion
    }
}