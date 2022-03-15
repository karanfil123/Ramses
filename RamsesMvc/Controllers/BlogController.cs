using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
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
            return View();
        }
    }
}
