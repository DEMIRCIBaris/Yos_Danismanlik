using FluentValidation;
using MyProject.Entities.DTO.AppUserDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.AppUser
{
    public class UserSignInValidator:AbstractValidator<UserSignInDto>
    {
        public UserSignInValidator()
        {
            RuleFor(i => i.UserName).NotNull().WithMessage("Kullanıcı Adı Boş Olamaz");
            RuleFor(i => i.Password).NotNull().WithMessage("Parola Boş Olamaz");
        }
    }
}
