using FluentValidation;
using MyProject.Entities.DTO.YosQuestionsDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Bussiness.ValidationRules.FluentValidation.YosQuestions
{
    public class YosQuestionsAddValidator : AbstractValidator<YosQuestionsAddDto>
    {
        public YosQuestionsAddValidator()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("Soru Dosyası adı boş olamaz.");
            RuleFor(i => i.DocumentUrl).NotNull().WithMessage("Dosya alanı boş bırakılamaz.");
        }
    }
}
