using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult WriterSidebarPartial()
        {
            return PartialView();
        }
    }
}
