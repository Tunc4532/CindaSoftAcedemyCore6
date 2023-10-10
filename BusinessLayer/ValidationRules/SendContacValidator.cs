using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SendContacValidator : AbstractValidator<Contact>
    {
        public SendContacValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter veri girişi yapmanız gerekmektedir");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en Fazla 100 karakter veri girişi yapmanız gerekmektedir");
            RuleFor(x => x.MessageBody).MaximumLength(100).WithMessage("Mesaj alanına en fazla 100 karakter veri girişi yapmanız gerekmektedir");
            RuleFor(x => x.MessageBody).MinimumLength(20).WithMessage("Mesaj alanına en ez 20 karakter veri girişi yapmanız gerekmektedir");

        }
    }
}
