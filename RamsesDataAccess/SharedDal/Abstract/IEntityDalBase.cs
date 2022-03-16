using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RamsesDataAccess.SharedDal.Abstract
{
    public interface IEntityDalBase<T> where T:class,new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int Id);
        List<T> GetList(Expression<Func<T, bool>> predicate);
    }
}
