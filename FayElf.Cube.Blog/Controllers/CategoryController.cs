using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XiaoFeng.Mvc;
using XiaoFeng;
using FayElf.Blog.Model;

namespace FayElf.Cube.Blog.Controllers
{
    /// <summary>
    /// 分类操作
    /// </summary>
    public class CategoryController : EntityController<ZWTbCategoryModel>
    {
        /// <summary>
        /// 获取分类
        /// </summary>
        /// <param name="ParentID">父类</param>
        /// <param name="Pass">是否展示隐藏 -1显示全部 0显示隐藏 1显示显示</param>
        /// <returns></returns>
        [HttpGet("/Category/Get/{ParentID}")]
        [HttpPost("/Category/Get/{ParentID}")]
        public JsonContent Get(int ParentID = 0, int Pass = -1)
        {
            return JsonSuccess(GetChild(ParentID, Pass));
        }
        /// <summary>
        /// 获取分类
        /// </summary>
        /// <param name="ParentID">父类</param>
        /// <param name="Pass">是否展示隐藏 -1显示全部 0显示隐藏 1显示显示</param>
        /// <returns></returns>
        private List<Category> GetChild(int ParentID = 0, int Pass = -1)
        {
            var QueryX = this.Entity.QueryableX.OrderBy(a => a.SortID).Where(a => a.ParentID == ParentID);
            if (Pass > -1) QueryX = QueryX.Where(a => a.Pass == Pass);
            var list = QueryX.Select(a => new Category { name = a.Name, value = a.ID.Value }).ToList();
            if (list == null || list.Count == 0)
                return new List<Category>();
            else
                list.Each(a =>
                {
                    a.child = GetChild(a.value, Pass);
                });
            return list;
        }
    }
    /// <summary>
    /// 分类结构
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 分类值
        /// </summary>
        public int value { get; set; }
        /// <summary>
        /// 分类子集
        /// </summary>
        public List<Category> child { get; set; }
    }
}