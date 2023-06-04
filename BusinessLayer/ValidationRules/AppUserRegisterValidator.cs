using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Bu Kısım Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu Kısım Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu Kısım Boş Geçilemez");
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Parola en az 8 karakter olmalıdır");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Paralanızı Tekrar Giriniz");
            RuleFor(x => x.Password).Equal(y=> y.ConfirmPassword).WithMessage("Parolalar eşleşmedi!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Bu Kısım Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Kısım Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Kısım Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Kısım Boş Geçilemez");

        }
    }
}
