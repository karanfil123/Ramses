using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.ViewsComponents
{
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager mm = new MessageManager(new MessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "bk@gmail.com";
            var val = mm.GetAll();
            ViewBag.mc = val.Count();
            return View(val);
        }
    }
}
