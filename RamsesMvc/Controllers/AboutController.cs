using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{ 
    public class AboutController : Controller
    {

        AboutManager ab = new AboutManager(new AboutRepository());
        
        public IActionResult Index()
        {
            var val = ab.GetList();
            return View(val);
        }
        public PartialViewResult Social_Media()
        {
            return PartialView();
        }
    }
}
