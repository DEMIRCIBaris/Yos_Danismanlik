using FluentValidation;
using MyProject.Entities.DTO.YosQuotaDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.YosQuota
{
    public class YosQuotaAddValidator : AbstractValidator<YosQuotaAddDto>
    {
        public YosQuotaAddValidator()
        {
            RuleFor(i => i.UniversityName).NotNull().WithMessage("Üniversite Adı alanı boş bırakılamaz.");
            RuleFor(i => i.Departments).NotNull().WithMessage("Bölüm alanı boş bırakılamaz.");
            RuleFor(i => i.Time).NotNull().WithMessage("Süre alanı boş bırakılamaz.");
            RuleFor(i => i.Quota).NotNull().WithMessage("Kontejyan kısmı boş bırakılamaz.");
        }
    }
}
