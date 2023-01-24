using Business.Abstract;
using Core.Helpers;
using DataAccess.Abstract;
using Entity.Concreate;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;
        private readonly IFileHelper _fileHelper;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ImageManager(IImageDal imageDal, IFileHelper fileHelper, IHostingEnvironment hostingEnvironment)
        {
            _imageDal = imageDal;
            _fileHelper = fileHelper;
            _hostingEnvironment = hostingEnvironment;
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetAll();
        }

        public Image GetById(int id)
        {
            return _imageDal.GetById(id);
        }

        public Image GetByImageUrl(string imageName)
        {
            var image = _imageDal.Get(i => i.ImageName == imageName);

            return new Image
            {
                Id = image.Id,
                ImageUrl = $"https://localhost:7124/project-img/{image.ImageUrl}",
                ImageName = image.ImageName
            };
        }

        public void Delete(string folder, int imageId)
        {
            Image image = _imageDal.GetById(imageId);
            _fileHelper.Delete(folder, image.ImageUrl);
            _imageDal.DeleteByEntity(image);
        }

        public void Update(IFormFile file, string folder, int id)
        {
            Image image = _imageDal.GetById(id);
            string oldPath = image.ImageUrl;

            image.ImageUrl = _fileHelper.Update(file, folder, oldPath);

            _imageDal.Update(image);
        }

        public void Upload(List<IFormFile> files, string folderName, string fileName)
        {
            foreach (IFormFile file in files)
            {
                string imagePath = _fileHelper.Upload(file, folderName);
                _imageDal.Add(new Image
                {
                    ImageName = fileName,
                    ImageUrl = imagePath
                });
            }
        }
    }
}
