using Entites.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.FirstName).NotNull();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(3);
            RuleFor(u => u.LastName).NotNull();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Password).NotNull();
            RuleFor(u => u.Password).MinimumLength(8);
        }
    }
}
