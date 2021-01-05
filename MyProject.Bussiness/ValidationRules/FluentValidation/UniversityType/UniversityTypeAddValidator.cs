using FluentValidation;
using MyProject.Entities.DTO.UniversityTypeDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.AppUniversityType
{
    public class UniversityTypeAddValidator : AbstractValidator<UniversityTypeAddDto>
    {
        public UniversityTypeAddValidator()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("Üniversite tipi boş olamaz.");
        }
    }
}
