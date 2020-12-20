using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Bussiness.ValidationRules.FluentValidation.AppUser;
using MyProject.Entities.DTO.AppUserDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.Extensions.ValidationConfig
{
    public static class ValidationConfiguration
    {
        public static void ValidatorConfig(this IServiceCollection services)
        {
            services.AddTransient<IValidator<UserAddDto>, UserAddValidator>();
            services.AddTransient<IValidator<UserSignInDto>, UserSignInValidator>();
        }
    }
}
