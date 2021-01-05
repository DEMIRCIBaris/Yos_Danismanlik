using FluentValidation;
using MyProject.Entities.DTO.YosQuestionsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.YosQuestions
{
    public class YosQuestionsUpdateValidator : AbstractValidator<YosQuestionsUpdateDto>
    {
        public YosQuestionsUpdateValidator()
        {
            RuleFor(i => i.Id).NotNull().WithMessage("Güncelleme işlemmi için soru dosyası seçiniz.");
            RuleFor(i => i.Name).NotNull().WithMessage("Soru Dosyası adı boş olamaz.");
            RuleFor(i => i.DocumentUrl).NotNull().WithMessage("Dosya alanı boş bırakılamaz.");
        }
    }
}
