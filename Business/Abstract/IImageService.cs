using Entity.Concreate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IImageService
    {
        List<Image> GetAll();
        Image GetById(int id);
        Image GetByImageUrl(string imageName);

        void Upload(List<IFormFile> files, string folderName, string fileName);
        void Delete(string folder, int imageId);
        void Update(IFormFile file, string folder, int id);
    }
}
