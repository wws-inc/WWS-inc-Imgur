using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using WWSInc.Imgur.Core.Models.Data;
using WWSInc.Imgur.Data.EF;
using ImgurData = WWSInc.Imgur.Data.EF.Model;

namespace WWSInc.Imgur.Data.SqlServer.Extensions
{
    public static class ImgurDataExtensions
    {
        public static IServiceCollection AddImgurEF<T>(this IServiceCollection services, 
            Action<DbContextOptionsBuilder> dboptions, 
            ServiceLifetime scope = ServiceLifetime.Scoped) where T : DbContext, IImgurDbContext
        {
            services.AddDbContext<T>(dboptions);

            return AddPiranhaEF<T>(services, scope);
        }


        public static IServiceCollection AddPiranhaEF<T>(this IServiceCollection services,
            ServiceLifetime scope = ServiceLifetime.Scoped) where T : DbContext, IImgurDbContext
        {
            //// Register repositories
            services.Add(new ServiceDescriptor(typeof(IProfileModel), typeof(ImgurData.ProfileModel), scope));

            //// Register services
            services.Add(new ServiceDescriptor(typeof(IImgurDbContext), typeof(T), scope));

            return services;
        }

    }
}