using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;

namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 知识库
    /// </summary>
    [AdminMenu("知识库管理", "博客管理", "zw-icon-knowledge1", 1)]
    public class KnowledgeController : AdminEntityController<ZWTbKnowledgeModel>
    {
        #region 更新知识库排序
        /// <summary>
        /// 更新知识库排序
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="SortID">排序值</param>
        /// <returns></returns>
        [HttpPost]
        [AdminAuthorize(PermissionFlags.Update)]
        public JsonContent UpdateSortID(int ID, int SortID)
        {
            if (ID == 0) return JsonError("参数出错.");
            var model = ZWTbKnowledgeModel.Create.Find(a => a.ID == ID);
            if (model == null) return JsonError("您所修改的数据不存在.");
            model.SortID = SortID;
            return Operate(model, a => a.Update(), "更新知识库排序");
        }
        #endregion
    }
}