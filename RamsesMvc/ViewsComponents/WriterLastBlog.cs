using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.ViewsComponents
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new BlogRepository());
        public IViewComponentResult Invoke()
        {
            var val = bm.GetBlogListByWriter(3);
            return View(val);
        }
    }
}
