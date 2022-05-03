using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesEntities.Concrete;
using RamsesServices.Concrete;
using RamsesServices.FluentValidator;
using X.PagedList;

namespace RamsesMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new CategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var val = cm.GetAll().ToPagedList(page, 5);
            return View(val);
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            ValidatorCategory cv = new ValidatorCategory();
            ValidationResult res = cv.Validate(category);
            if (res.IsValid)
            {
                cm.TAdd(category);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in res.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteCategory(int id)
        {
            var val = cm.Get(id);
            cm.TDelete(val);
            return RedirectToAction("Index");
        }
    }
}
