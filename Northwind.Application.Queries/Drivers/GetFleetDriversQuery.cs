using FleetControl.Application.Queries.Drivers;
using MediatR;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetDriversQuery : IRequest<FleetDriversViewModel>
    {
        public int Baid { get; set; }
    }
}
