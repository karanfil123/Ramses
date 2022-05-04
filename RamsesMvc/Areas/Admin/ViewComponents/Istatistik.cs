using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Contexts;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Areas.Admin.ViewComponents
{
    public class Istatistik : ViewComponent
    {
        private readonly Context _context;

        public Istatistik(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.BlogCount = _context.Blogs.Count();
            ViewBag.MessageCount = _context.Contacts.Count();
            ViewBag.CommentCount = _context.Comments.Count();
            return View();
        }
    }
}
