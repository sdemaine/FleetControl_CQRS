using FluentValidation;

namespace Northwind.Application.Commands.DeleteCustomer
{
    public class DeleteNorthwindCustomerCommandValidator : AbstractValidator<DeleteNorthwindCustomerCommand>
    {
        public DeleteNorthwindCustomerCommandValidator()
        {
            RuleFor(v => v.CustomerId).NotEmpty().Length(5);
        }
    }
}
