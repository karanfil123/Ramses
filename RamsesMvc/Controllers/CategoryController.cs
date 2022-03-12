using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Abstract;
using RamsesServices.Concrete;

namespace RamsesMvc.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new CategoryRepository());       

        public IActionResult Index()
        {
            var category = cm.GetAllCategory();
            return View(category);
        }
    }
}
