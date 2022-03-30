using FluentValidation;
using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.FluentValidator
{
    public class ValidatorWriter : AbstractValidator<Writer>
    {
        public ValidatorWriter()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar adı-soyadı alanı boş geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("E-Posta alanı boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Yazar adı-soyadı {0} karekterden az olamaz.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Yazar adı-soyadı {0} karekterden fazla olamaz.");
            RuleFor(x => x.Policy).NotEmpty().WithMessage("Kullanıcı şartlarını seçiniz.");
        }
    }
}
