using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {

        public CarValidator()
        {
            RuleFor(ca => ca.DailyPrice).NotEmpty();
            RuleFor(ca => ca.DailyPrice).GreaterThan(10);
            RuleFor(ca => ca.CarName).MinimumLength(3);
        }
    }
}