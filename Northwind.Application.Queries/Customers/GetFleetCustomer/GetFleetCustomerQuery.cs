using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerQuery : IRequest<GetFleetCustomerViewModel>
    {
        public int Baid { get; set; }
    }
}
