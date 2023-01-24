using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Core.Helpers
{
    public class FileHelperManager : IFileHelper
    {
        private IHostingEnvironment _hostingEnvironment;

        public FileHelperManager(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public string Upload(IFormFile file, string folderName)
        {
            string uploadFile = Path.Combine(_hostingEnvironment.WebRootPath, folderName);

            if (!Directory.Exists(uploadFile))
                Directory.CreateDirectory(uploadFile);

            string guidName = Guid.NewGuid().ToString();
            string fileName = $"{guidName}{Path.GetExtension(file.FileName)}";
            string fullPath = Path.Combine(uploadFile, fileName);

            using FileStream fileStream = new(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);

            file.CopyTo(fileStream);
            fileStream.Flush();
            return fileName;
        }

        public void Delete(string folder, string filePath)
        {
            string deleteFile = Path.Combine(_hostingEnvironment.WebRootPath, $"{folder}/{filePath}");
            if (File.Exists(deleteFile))
                File.Delete(deleteFile);
        }

        public string Update(IFormFile file, string folder, string oldFile)
        {
            string deleteFile = Path.Combine(_hostingEnvironment.WebRootPath, $"{folder}/{oldFile}");
            Delete(folder, oldFile);
            return Upload(file, folder); ;
        }
    }
}
