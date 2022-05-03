
using FluentValidation;
using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.FluentValidator
{
    public class ValidatorCategory : AbstractValidator<Category>
    {
        public ValidatorCategory()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adını boş geçmeyin.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Kategori 3 karekterden az olamaz.");
            RuleFor(x => x.Name).MaximumLength(150).WithMessage("Kategori 150 karekterden fazla olamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kategori adını boş geçmeyin.");
        }
    }
}
