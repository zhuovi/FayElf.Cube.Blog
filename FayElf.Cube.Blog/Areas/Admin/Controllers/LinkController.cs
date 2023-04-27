using FayElf.Blog.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/****************************************************************
*  Copyright © (2023) www.fayelf.com All Rights Reserved.       *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@fayelf.com                                     *
*  Site : www.fayelf.com                                        *
*  Create Time : 2023-04-24 09:39:34                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace FayElf.Cube.Blog.Areas.Admin.Controllers
{
    /// <summary>
    /// 链接管理
    /// </summary>
    [AdminMenu("链接管理", "内容管理", "zw-icon zw-icon-link1", 5)]
    public class LinkController : AdminEntityController<ZWTbLinkModel>
    {
    }
}