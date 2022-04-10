using RamsesDataAccess.SharedDal.Abstract;
using RamsesEntities.Concrete;
using System.Collections.Generic;

namespace RamsesDataAccess.Abstract
{
    public interface IBlogDal : IEntityDalBase<Blog>
    {
        List<Blog> GetListByCategory();
        List<Blog> GetListByCategoryByWriter( int id);
    }
}
