using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductPrice).NotEmpty();
            RuleFor(p => p.ProductPrice).GreaterThan(0);
            RuleFor(p => p.ProductPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

        }
    }
}
