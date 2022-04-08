using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesEntities.Concrete;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
    public class SubscribeController : Controller
    {
        SubscribeManager sm = new SubscribeManager(new SubscribeRepository());

        [HttpGet]
        public PartialViewResult AddSubscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddSubscribe(Subscribe s)
        {
            sm.Addsubscribe(s);
            return PartialView();
        }
    }
}
