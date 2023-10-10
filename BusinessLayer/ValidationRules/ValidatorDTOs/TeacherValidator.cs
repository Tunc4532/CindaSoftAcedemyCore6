using DTOLayer.DTOs.TeacherDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ValidatorDTOs
{
    public class TeacherValidator : AbstractValidator<TeacherAddDTOs>
    {
        public TeacherValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("öğretmen ad alanı boş geçilemez");
            RuleFor(x => x.Section).NotEmpty().WithMessage("öğretmen branş alanı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("öğretmen fotoğraf alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("en az 3 karakterlik veri girişi yapılmalıdır");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("en fazla 30 karakterlik veri girişi yapılmalıdır");
        }
    }
}
