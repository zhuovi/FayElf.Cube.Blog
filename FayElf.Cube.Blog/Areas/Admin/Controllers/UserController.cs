using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;

namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    [AdminMenu("用户管理", "博客管理", "zw-icon zw-icon-user1", 5)]
    public class UserController : AdminEntityController<ZWTbUserModel>
    {
        
    }
}