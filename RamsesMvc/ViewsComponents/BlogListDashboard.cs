using Microsoft.AspNetCore.Mvc;
using RamsesDataAccess.Concrete.Repositories;
using RamsesServices.Concrete;

namespace RamsesMvc.ViewsComponents
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager bm = new BlogManager(new BlogRepository());
        public IViewComponentResult Invoke()
        {
            var val = bm.GetBlogListByCategory();
            return View(val);
        }
    }
}
