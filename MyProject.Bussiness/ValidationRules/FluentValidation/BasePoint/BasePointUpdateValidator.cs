using FluentValidation;
using MyProject.Entities.DTO.BasePointDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.BasePoint
{
    public class BasePointUpdateValidator : AbstractValidator<BasePointUpdateDto>
    {
        public BasePointUpdateValidator()
        {
            RuleFor(i => i.Id).NotNull().WithMessage("Güncelleme işlemi için bölüm seçiniz. ");
            RuleFor(i => i.Department).NotNull().WithMessage("Bölüm adı boş olamaz.");
            RuleFor(i => i.FirstCities).NotNull().WithMessage("1.Şehir puanı boş bırakılamaz.");
            RuleFor(i => i.SecondCities).NotNull().WithMessage("2.Şehir puanı boş bırakılamaz.");
            RuleFor(i => i.ThirdCities).NotNull().WithMessage("3.Şehir puanı boş bırakılamaz.");
        }
    }
}
