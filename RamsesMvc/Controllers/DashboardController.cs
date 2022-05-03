using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Contexts;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new BlogRepository());
        Context con = new Context();
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.bs = con.Blogs.Count().ToString();
            ViewBag.wbs = con.Blogs.Where(x=>x.WriterId==2).Count().ToString();
            ViewBag.cs = con.Categories.Count().ToString();
          

            return View();
        }
    }
}
