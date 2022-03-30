using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Abstract;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new CommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }

    }
}
