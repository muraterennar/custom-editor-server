using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concreate;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class BlogDal : EfEntityRepositoryBase<Blog, MyDbContext>, IBlogDal
    {
        public List<BlogDetailDto> GetAllByDto()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var result = from blog in context.Blogs
                             join blogCategory in context.BlogCategories on blog.BlogCategoryId equals blogCategory.Id
                             select new BlogDetailDto
                             {
                                 Id = blog.Id,
                                 BlogTitle = blog.BlogTitle,
                                 CategoryName = blogCategory.CategoryName,
                                 BlogDescription = blog.BlogDescription
                             };
                return result.ToList();
            }
        }

        public List<BlogDetailDto> GetListByIdForDto(int id)
        {
            return GetAllByDto().Where(x => x.Id == id).ToList();
        }

        public BlogDetailDto GetByIdForDto(int id)
        {
            return GetAllByDto().SingleOrDefault(x => x.Id == id);
        }

        public BlogDetailDto GetByBlogNameForDto(string blogTitle)
        {
            return GetAllByDto().SingleOrDefault(x => x.BlogTitle == blogTitle);
        }
    }
}
