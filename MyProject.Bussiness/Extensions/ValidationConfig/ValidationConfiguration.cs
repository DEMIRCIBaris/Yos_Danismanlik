using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Bussiness.ValidationRules.FluentValidation.AppUniversity;
using MyProject.Bussiness.ValidationRules.FluentValidation.AppUniversityType;
using MyProject.Bussiness.ValidationRules.FluentValidation.AppUser;
using MyProject.Bussiness.ValidationRules.FluentValidation.BasePoint;
using MyProject.Bussiness.ValidationRules.FluentValidation.YosQuestions;
using MyProject.Bussiness.ValidationRules.FluentValidation.YosQuota;
using MyProject.Entities.DTO.UniversityDTO;
using MyProject.Entities.DTO.UniversityTypeDTO;
using MyProject.Entities.DTO.AppUserDTO;
using MyProject.Entities.DTO.BasePointDTO;
using MyProject.Entities.DTO.YosQuestionsDTO;
using MyProject.Entities.DTO.YosQuotaDTO;


namespace MyProject.Bussiness.Extensions.ValidationConfig
{
    public static class ValidationConfiguration
    {
        public static void ValidatorConfig(this IServiceCollection services)
        {
            services.AddTransient<IValidator<UserAddDto>, UserAddValidator>();
            services.AddTransient<IValidator<UserSignInDto>, UserSignInValidator>();
            services.AddTransient<IValidator<UniversityTypeAddDto>, UniversityTypeAddValidator>();
            services.AddTransient<IValidator<UniversityTypeUpdateDto>, UniversityTypeUpdateValidator>();
            services.AddTransient<IValidator<UniversityAddDto>, UniversityAddValidator>();
            services.AddTransient<IValidator<UniversityUpdateDto>, UniversityUpdateValidator>();
            services.AddTransient<IValidator<YosQuestionsAddDto>, YosQuestionsAddValidator>();
            services.AddTransient<IValidator<YosQuestionsUpdateDto>, YosQuestionsUpdateValidator>();
            services.AddTransient<IValidator<YosQuotaUpdateDto>, YosQuotaUpdateValidator>();
            services.AddTransient<IValidator<YosQuotaAddDto>, YosQuotaAddValidator>();
            services.AddTransient<IValidator<BasePointAddDto>, BasePointAddValidator>();
            services.AddTransient<IValidator<BasePointUpdateDto>, BasePointUpdateValidator>();
        }
    }
}