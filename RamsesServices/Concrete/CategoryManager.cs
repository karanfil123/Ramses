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

        public void CategoryAdd(Category category)
        {
            categoryDal.Add(category);
        }

        public void CategoryDelete(Category category)
        {

            categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryDal.Update(category);
        }

        public List<Category> GetAllCategory()
        {
            return categoryDal.GetAll();
        }

        public Category GetCategory(int Id)
        {
            return categoryDal.GetById(Id);
        }
    }
}
