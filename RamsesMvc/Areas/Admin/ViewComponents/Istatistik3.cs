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
            return View();
        }
    }
}
