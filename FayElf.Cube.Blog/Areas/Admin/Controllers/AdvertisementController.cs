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
    /// 广告管理
    /// </summary>
    [AdminMenu("广告管理", "内容管理", "zw-icon zw-icon-ad", 4)]
    public class AdvertisementController : AdminEntityController<VIEWAdvertisementModel>
    {
        #region 更新广告状态
        /// <summary>
        /// 更新广告状态
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="Pass">状态</param>
        /// <returns></returns>
        [HttpPost]
        [AdminAuthorize(PermissionFlags.Update)]
        public JsonContent SetPass(int ID, short Pass)
        {
            if (ID == 0) return JsonError("设置广告状态失败");
            var adv = ZWTbAdvertisementModel.Create.Find(a => a.ID == ID);
            if (adv == null) return JsonError("当前广告不存在");
            adv.Pass = Pass;
            return this.Operate(adv, a => a.Update(), "设置广告状态");
        }
        #endregion
    }
}