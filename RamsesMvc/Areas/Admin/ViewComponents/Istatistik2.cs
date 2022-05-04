using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Areas.Admin.ViewComponents
{
    public class Istatistik2 : ViewComponent
    {
        private readonly Context _context;

        public Istatistik2(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SonBlog = _context.Blogs.OrderByDescending(x => x.ID).Select(x => x.Title).Take(1).FirstOrDefault();
            return View();
        }
    }
}
