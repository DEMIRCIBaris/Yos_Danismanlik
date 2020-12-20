using Microsoft.Extensions.DependencyInjection;
using MyProject.Bussiness.Abstract;
using MyProject.Bussiness.Concrete;
using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework;

namespace MyProject.Bussiness.Extensions.DIResolvers
{
    public static class StartupDIResolvers
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IMapperService, MapperService>();
        }
    }
}
