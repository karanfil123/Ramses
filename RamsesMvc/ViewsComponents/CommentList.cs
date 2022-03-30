using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.ViewsComponents
{
    public class CommentList:ViewComponent
    {
        CommentManager cm = new CommentManager(new CommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var val = cm.GetAllComment( id);
            return View(val);
        }
    }
}
