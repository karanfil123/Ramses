using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Areas.Admin.ViewComponents
{
    public class Istatistik3 : ViewComponent
    {
        private readonly Context _context;

        public Istatistik3(Context context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Name = _context.Admins.Where(x => x.ID == 1).Select(x => x.NameSurname).FirstOrDefault();
            ViewBag.img = _context.Admins.Where(x => x.ID == 1).Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.Desc = _context.Admins.Where(x => x.ID == 1).Select(x => x.Description).FirstOrDefault();
            return View();
        }
    }
}
