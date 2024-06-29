using DarthSeldon.API.FluentValidation.Demo.Records;
using FluentValidation;

namespace DarthSeldon.API.FluentValidation.Demo.Validators
{
    /// <summary>
    /// Product Validator
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator&lt;DarthSeldon.API.FluentValidation.Demo.Records.Product&gt;" />
    public class ProductValidator : AbstractValidator<Product>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductValidator"/> class.
        /// </summary>
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Price).NotNull().PrecisionScale(4, 2, false).GreaterThan(0);
        }

        #endregion Constructors
    }
}