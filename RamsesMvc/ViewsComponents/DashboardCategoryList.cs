using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.ViewsComponents
{
    public class DashboardCategoryList : ViewComponent
    {
        CategoryManager category = new CategoryManager(new CategoryRepository());
        public IViewComponentResult Invoke()
        {
            var val = category.GetAll();
            return View(val);
        }
    }
}
