using Business.Abstract;
using Business.Concreate;
using Core.Helpers;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concreate;
using System.Collections;

namespace WebAPI.Configuration
{
    public static class APIConfiguration
    {
        public static void Load(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IImageDal, ImageDal>();
            serviceCollection.AddSingleton<IFileHelper, FileHelperManager>();
            serviceCollection.AddSingleton<IImageService, ImageManager>();

            serviceCollection.AddSingleton<IBlogDal, BlogDal>();
            serviceCollection.AddSingleton<IBlogService, BlogManager>();

            serviceCollection.AddSingleton<IBlogCategoryDal, BlogCategoryDal>();
            serviceCollection.AddSingleton<IBlogCategoryService, BLogCategoryManager>();

            serviceCollection.AddSingleton<MyDbContext>();
        }
    }
}
