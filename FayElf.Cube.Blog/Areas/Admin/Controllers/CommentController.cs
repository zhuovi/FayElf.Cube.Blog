using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;

namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 评论管理
    /// </summary>
    [AdminMenu("评论管理", "博客管理", "zw-icon zw-icon-sms", 4)]
    public class CommentController : AdminEntityController<ZWTbCommentModel>
    {
    }
}
