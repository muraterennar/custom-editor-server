using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class BLogCategoryManager : IBlogCategoryService
    {
        readonly IBlogCategoryDal _blogCategoryDal;

        public BLogCategoryManager(IBlogCategoryDal blogCategoryDal)
        {
            _blogCategoryDal = blogCategoryDal;
        }

        public List<BlogCategory> GetAll()
        {
            return _blogCategoryDal.GetAll();
        }

        public BlogCategory GetById(int id)
        {
            return _blogCategoryDal.GetById(id);
        }

        public BlogCategory GetByName(string name)
        {
            return _blogCategoryDal.Get(b => b.CategoryName == name);
        }

        public void Add(BlogCategory category)
        {
            _blogCategoryDal.Add(category);
        }

        public void Delete(BlogCategory category)
        {
            _blogCategoryDal.DeleteByEntity(category);
        }

        public void DeleteById(int id)
        {
            _blogCategoryDal.DeleteById(id);
        }

        public void Update(BlogCategory category)
        {
            _blogCategoryDal.Update(category);
        }
    }
}
