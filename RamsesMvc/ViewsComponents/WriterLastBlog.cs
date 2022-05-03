using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Contexts;
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
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.Mail == usermail).Select(x => x.ID).FirstOrDefault();
            var val = bm.GetBlogListByWriter(writerID);
            return View(val);
        }
    }
}
