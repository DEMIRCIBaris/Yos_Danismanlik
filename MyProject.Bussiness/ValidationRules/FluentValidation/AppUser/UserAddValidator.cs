using FluentValidation;
using MyProject.Entities.DTO.AppUserDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.AppUser
{
    public class UserAddValidator : AbstractValidator<UserAddDto>
    {
        public UserAddValidator()
        {
            RuleFor(i => i.UserName).NotNull().WithMessage("Kullanıcı Adı Boş olamaz");
            RuleFor(i => i.Password).NotNull().WithMessage("Parola alanı boş olamaz");
            RuleFor(i => i.ConfirmPassword).NotNull().WithMessage("Parola onay alanı boş olamaz");
            RuleFor(i => i.ConfirmPassword).Equal(i => i.Password).WithMessage("Parolalar eşleşmiyor");
            RuleFor(i => i.PhoneNumber).NotNull().WithMessage("Telefon alanı boş olamaz.");
            RuleFor(i => i.Email).NotNull().WithMessage("Email alanı boş olamaz").EmailAddress().WithMessage("Geçersiz email adresi");
            RuleFor(i => i.Name).NotNull().WithMessage("Ad alanı Boş olamaz");
            RuleFor(i => i.Surname).NotNull().WithMessage("Soyad alanı boş olamaz");
        }
    }
}
