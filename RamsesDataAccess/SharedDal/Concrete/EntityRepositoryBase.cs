using RamsesDataAccess.Concrete.Contexts;
using RamsesDataAccess.SharedDal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RamsesDataAccess.SharedDal.Concrete
{
    public class EntityRepositoryBase<T> : IEntityDalBase<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var c = new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            using var c = new Context();
            return c.Set<T>().Find(Id);
        }

        public List<T> GetList(Expression<Func<T, bool>> predicate)
        {
            using var c = new Context();
            return c.Set<T>().Where(predicate).ToList();
        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
