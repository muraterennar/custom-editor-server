using Core.DataAccess;
using Entity.Concreate;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IEntityRespository<Blog>
    {
        List<BlogDetailDto> GetAllByDto();
        List<BlogDetailDto> GetListByIdForDto(int id);
        BlogDetailDto GetByIdForDto(int id);
        BlogDetailDto GetByBlogNameForDto(string blogTitle);
    }
}
