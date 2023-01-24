using Entity.Concreate;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        List<BlogDetailDto> GetAllByDto();
        Blog GetById(int id);
        Blog GetByCategoryId(int categoryId);
        BlogDetailDto BlogDetailDtoById(int id);
        BlogDetailDto BlogDetailDtoByBlogName(string blogTitle);

        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
    }
}
