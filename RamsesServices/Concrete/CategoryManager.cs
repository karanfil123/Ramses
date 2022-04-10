using RamsesDataAccess.Abstract;
using RamsesDataAccess.Concrete.Repositories;
using RamsesEntities.Concrete;
using RamsesServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }       

        public Category Get(int Id)
        {
            return categoryDal.GetById(Id);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }       
        public void TAdd(Category t)
        {
            categoryDal.Add(t);
        }

        public void TDelete(Category t)
        {
            categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            categoryDal.Update(t);
        }
    }
}
