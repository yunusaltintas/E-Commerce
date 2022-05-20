using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.ViewModels.Validator
{
    public class LoginInputValidator : AbstractValidator<UserLoginViewModel>
    {
        public LoginInputValidator()
        {
            RuleFor(o => o.UserName).NotEmpty().NotNull();
            RuleFor(o => o.Password).NotEmpty().NotNull();
        }
    }
}
