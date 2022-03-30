using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesEntities.Concrete;
using RamsesServices.Concrete;
using RamsesServices.FluentValidator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new WriterRepository());
        [HttpGet]
        public IActionResult Index()
        {           
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            ValidatorWriter valid = new ValidatorWriter();
            ValidationResult result = valid.Validate(writer);
            if (result.IsValid)
            {
                writer.CreateByName = "Bülent";
                writer.CreateDate = DateTime.Now;
                writer.ModifiedByName = "Bülent";
                writer.ModifiedDate = DateTime.Now;
                writer.IsActive = true;
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Login");
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
    }
}
