using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RamsesDataAccess.Concrete.Repositories;
using RamsesEntities.Concrete;
using RamsesServices.Concrete;
using RamsesServices.FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RamsesMvc.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        BlogManager bm = new BlogManager(new BlogRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult WriterSidebarPartial()
        {
            return PartialView();
        }
        public IActionResult BlogListWriter()
        {
            var val = bm.GetBlogListWithCategoryByWriter(2);
            return View(val);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new CategoryRepository());
            List<SelectListItem> categoryVal = (from x in cm.GetAll()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.ID.ToString()
                                                }).ToList();
            ViewBag.cv = categoryVal;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog b)
        {
            ValidatorBlog vb = new ValidatorBlog();
            ValidationResult result = vb.Validate(b);
            if (result.IsValid)
            {
                b.CreateByName = "Bülent";
                b.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                b.ModifiedByName = "-";
                b.ModifiedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                b.IsActive = true;
                b.WriterId = 2;
                bm.BlogAdd(b);
                return RedirectToAction("BlogListWriter", "Writer");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var val = bm.GetBlogId(id);
            if (val != null)
            {
                bm.BlogDelete(val);
                return RedirectToAction("BlogListWriter", "Writer");
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            CategoryManager cm = new CategoryManager(new CategoryRepository());
            List<SelectListItem> categoryVal = (from x in cm.GetAll()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.ID.ToString()
                                                }).ToList();
            ViewBag.catV = categoryVal;           
            var val = bm.GetBlogId(id);
            return View(val);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog b)
        {
            var val = bm.GetBlogId(b.ID);
            b.WriterId = val.WriterId;
            b.CreateDate = val.CreateDate;
            b.ModifiedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            b.ModifiedByName = val.ModifiedByName;
            b.IsActive = val.IsActive;
            bm.BlogUpdate(b);           
            return RedirectToAction("BlogListWriter");
        }
    }
}
