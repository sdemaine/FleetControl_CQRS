using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomersListQuery : IRequest<FleetCustomersListViewModel>
    {
    }
}
