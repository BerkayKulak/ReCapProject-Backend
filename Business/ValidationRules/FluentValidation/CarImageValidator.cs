using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImages>
    {
        public CarImageValidator()
        {
            RuleFor(i => i.CarId).NotEmpty();
            RuleFor(i => i.History).NotEmpty();
        }

    }
}