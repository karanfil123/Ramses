using Microsoft.EntityFrameworkCore;
using RamsesDataAccess.Abstract;
using RamsesDataAccess.Concrete.Contexts;
using RamsesDataAccess.SharedDal.Concrete;
using RamsesEntities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace RamsesDataAccess.Concrete.Repositories
{
    public class BlogRepository : EntityRepositoryBase<Blog>, IBlogDal
    {
        public List<Blog> GetListByCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
                
            }
        }
    }
}
