using FluentValidation;
using MyProject.Entities.DTO.UniversityDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.AppUniversity
{
    public class UniversityAddValidator : AbstractValidator<UniversityAddDto>
    {
        public UniversityAddValidator()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("Üniversite adı boş olamaz.");
            RuleFor(i => i.PictureUrl).NotNull().WithMessage("Logo alanı boş bırakılamaz.");
            RuleFor(i => i.CityId).NotNull().WithMessage("Şehir seçiniz.");
            RuleFor(i => i.UniversityTypeId).NotNull().WithMessage("Üniversite tipini seçiniz.");
            RuleFor(i => i.URL).NotNull().WithMessage("Adres kısmı boş bırakılamaz.");

        }
    }
}
