using MediatR;

namespace FleetControl.Application.Queries.GetCustomerList
{
    public class GetFleetCustomersListQuery : IRequest<FleetCustomersListViewModel>
    {
    }
}
