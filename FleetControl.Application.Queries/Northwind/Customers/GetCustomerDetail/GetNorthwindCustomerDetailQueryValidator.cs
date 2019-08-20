using FluentValidation;
using Northwind.Application.Queries.GetCustomerDetail;

namespace Northwind.Application.Queries.GetCustomerDetail
{
    public class GetNorthwindCustomerDetailQueryValidator : AbstractValidator<GetNorthwindCustomerDetailQuery>
    {
        public GetNorthwindCustomerDetailQueryValidator()
        {
            RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
