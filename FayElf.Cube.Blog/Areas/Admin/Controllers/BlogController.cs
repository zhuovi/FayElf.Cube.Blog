using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;

namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 博客管理
    /// </summary>
    [AdminMenu("技术文章管理", "博客管理", "zw-icon zw-icon-knowledge2", 3)]
    public class BlogController : AdminEntityController<VIEWBlogModel>
    {
        
    }
}