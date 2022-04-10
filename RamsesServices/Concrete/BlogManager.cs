using RamsesDataAccess.Abstract;
using RamsesEntities.Concrete;
using RamsesServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetAllBlog()
        {
            return _blogDal.GetAll();
        }
        public List<Blog> Get3Blog()
        {
            return _blogDal.GetAll().Take(3).ToList();//take ile son eklenen 3 blog post listeleme
        }

        public Blog GetBlogId(int Id)
        {
            return _blogDal.GetById(Id);
        }

        public List<Blog> GetBlogListByCategory()
        {
            return _blogDal.GetListByCategory();
        }
        public List<Blog> GetBlogListById(int id)
        {
            return _blogDal.GetList(x => x.ID == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetList(x => x.WriterId == id);
        }

        public Blog GetCategoryById(int categoryId)
        {
            return _blogDal.GetById(categoryId);
        }

        public List<Blog> GetBlogListWithCategoryByWriter(int id)
        {
            return _blogDal.GetListByCategoryByWriter(id);
        }
    }
}
