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

            services.AddScoped<IUniversityService, UniversityService>();
            services.AddScoped<IUniversityDal, EFUniversityDal>();

            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<ICityService, CityService>();

            services.AddScoped<IUniversityTypeDal, EfUniversityTypeDal>();
            services.AddScoped<IUniversityTypeService, UnıversityTypeService>();

            services.AddScoped<IYosQuestionsDal, EfYosQuestionsDal>();
            services.AddScoped<IYosQuestionsService, YosQuestionsService>();

            services.AddScoped<IYosQuotaDal, EfYosQuotaDal>();
            services.AddScoped<IYosQuotaService, YosQuotaService>();

            services.AddScoped<IBasePointDal, EfBasePointDal>();
            services.AddScoped<IBasePointService, BasePointService>();

        }
    }
}
