using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using XiaoFeng.Data.SQL;

namespace FayElf.Cube.Blog.Controllers
{
    /// <summary>
    /// 搜索类
    /// </summary>
    public class SearchController : EntityController
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
        /// 搜索
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        [HttpPost("/Search/GetJson")]
        public JsonContent GetJson(string key)
        {
            if (key.IsNullOrEmpty()) return JsonError("关键词不能为空.");
            var k = key.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (k.Length == 0) return JsonOK();

            var i = 0;
            var ka = "%" + k[i].Trim() + "%";
            Expression<Func<VIEWBlogModel, bool>> where = a => a.Title.LikeSQL(ka) || a.Description.LikeSQL(ka) || a.ContentMD.LikeSQL(ka);
            if (k.Length > 1)
            {
                for (; i < k.Length; i++)
                {
                    var kb = "%" + k[i].Trim() + "%";
                    where = where.Or(a => a.Title.LikeSQLX(kb) || a.Description.LikeSQLX(kb) || a.ContentMD.LikeSQL(kb));
                }
            }
            where = where.And(a => a.Pass == 1);
            var q = VIEWBlogModel.Create.Where(where);
            var count = q.AS().Count();
            if (count == 0) return JsonSuccess("", 0);
            var limit = this.Post("limit", 10);
            var page = this.Post<int>("page", 1);
            var list = q.OrderBy(a => a.SortID).OrderByDescending(a => a.AddTimestamp).Select(a => new
            {
                a.ID,
                a.Title,
                a.Description,
                a.Image,
                a.AddDate,
                a.CatalogueID,
                a.CatalogueName,
                a.KnowledgeID,
                a.KnowledgeName
            }).Take(limit).Skip((page - 1) * limit).ToList();
            return JsonSuccess(list, count);
        }
    }
}
