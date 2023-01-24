using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogCategoryService
    {
        List<BlogCategory> GetAll();
        BlogCategory GetById(int id);
        BlogCategory GetByName(string name);

        void Add(BlogCategory category);
        void Update(BlogCategory category);
        void Delete(BlogCategory category);
        void DeleteById(int id);
    }
}
