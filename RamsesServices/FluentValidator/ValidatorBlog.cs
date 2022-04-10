using FluentValidation;
using RamsesEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamsesServices.FluentValidator
{
    public class ValidatorBlog : AbstractValidator<Blog>
    {
        public ValidatorBlog()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanını boş geçmeyiniz."); 
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik alanını boş geçmeyiniz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanını boş geçmeyiniz.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori seçiniz.");
        }
    }
}
