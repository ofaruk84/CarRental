using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {

        public CarValidator()
        {
            RuleFor(c => c.CarName).MaximumLength(1);
            RuleFor(c => c.DailyPrice).GreaterThan(200);// #12 1:22:53
        }
    }
}
