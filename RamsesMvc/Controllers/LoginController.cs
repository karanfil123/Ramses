using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Contexts;
using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context context = new Context();
            var dataVal = context.Writers.FirstOrDefault(x => x.Mail == writer.Mail && x.Password == x.Password);
            if (dataVal!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}
//Context context = new Context();
//var val = context.Writers.FirstOrDefault(x => x.Mail == writer.Mail && x.Password == writer.Password);
//if (val != null)
//{
//    HttpContext.Session.SetString("username", writer.Mail);
//    return RedirectToAction("Index", "Writer");
//}
//else
//{
//    return View();
//}
//return View();
