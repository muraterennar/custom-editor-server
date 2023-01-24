using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class ImageDal:EfEntityRepositoryBase<Image, MyDbContext>, IImageDal
    {

    }
}
