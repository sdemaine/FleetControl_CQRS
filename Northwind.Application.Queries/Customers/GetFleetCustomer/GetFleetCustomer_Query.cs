using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomer_Query : IRequest<GetFleetCustomer_ViewModel>
    {
        public int Baid { get; set; }
    }
}
