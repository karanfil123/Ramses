using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new BlogRepository());
        public IActionResult Index()
        {
            var blog = bm.GetBlogListByCategory();
            return View(blog);
        }
        public IActionResult BlogDetail( int id)
        {
            ViewBag.i = id;
            var val = bm.GetBlogListById(id);
            return View(val);
        }
    }
}
