using MediatR;

namespace FleetControl.Application.Queries.GetCustomerList
{
    public class GetCustomersListQuery : IRequest<CustomersListViewModel>
    {
    }
}
