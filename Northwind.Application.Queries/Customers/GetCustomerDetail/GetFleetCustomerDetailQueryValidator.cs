using FluentValidation;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetailQueryValidator : AbstractValidator<GetFleetCustomerDetailQuery>
    {
        public GetFleetCustomerDetailQueryValidator()
        {
            RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
