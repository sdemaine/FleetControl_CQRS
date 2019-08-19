using FleetControl.Application.Queries.Drivers;
using MediatR;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetDriverListQuery : IRequest<GetFleetDriverList_ViewModel>
    {
        public int Baid { get; set; }
    }
}
