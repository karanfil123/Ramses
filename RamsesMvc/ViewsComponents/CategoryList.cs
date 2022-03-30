using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.ViewsComponents
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new CategoryRepository());
        public IViewComponentResult Invoke()
        {
            var val = cm.GetAllCategory();
            return View(val);
        }
    }
}
