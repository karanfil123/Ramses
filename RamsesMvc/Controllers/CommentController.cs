using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Abstract;
using RamsesDataAccess.Concrete.Repositories;
using RamsesEntities.Concrete;
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
        [HttpGet]
        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddCommentPartial(Comment comment,Blog blog)
        {
           
            comment.CreateByName = "Bülent";
            comment.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.ModifiedByName = "Bülent";
            comment.ModifiedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.IsActive = true;
            comment.BlogId =2;
            cm.CommentAdd(comment);
            return PartialView();
        }

    }
}
