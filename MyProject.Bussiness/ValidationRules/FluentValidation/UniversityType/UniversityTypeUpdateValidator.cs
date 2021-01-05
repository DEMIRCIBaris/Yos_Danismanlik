using FluentValidation;
using MyProject.Entities.DTO.UniversityTypeDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.AppUniversityType
{
    public class UniversityTypeUpdateValidator : AbstractValidator<UniversityTypeUpdateDto>
    {
        public UniversityTypeUpdateValidator()
        {
            RuleFor(i => i.Id).NotNull().WithMessage("Güncelleme işlemi için lütfen bir tip seçiniz");
            RuleFor(i => i.Name).NotNull().WithMessage("Üniversite tipi boş olamaz.");
        }
    }
}
