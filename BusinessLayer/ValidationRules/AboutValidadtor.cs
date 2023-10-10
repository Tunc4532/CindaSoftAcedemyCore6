using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidadtor : AbstractValidator<About>
    {
        public AboutValidadtor()
        {
            RuleFor(x => x.Tittle).NotEmpty().WithMessage("Başlık kısmı boş geçilemez");
            RuleFor(x => x.Tittle).MinimumLength(5).WithMessage("Başlık kısmına en az 5 karakterlik veri girmeniz gerekmektedir");
        }
    }
}
