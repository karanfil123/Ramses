using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RamsesDataAccess.SharedDal.Abstract
{
    public interface IEntityDalBase<T> where T : class, new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int Id);
        T Get(Expression<Func<T, bool>> predicate);
        List<T> GetList(Expression<Func<T, bool>> predicate);
        List<T> GetListAndObject(Expression<Func<T, bool>> predicate,params Expression<Func<T,object>>[] IncPropObj);
    }
}
