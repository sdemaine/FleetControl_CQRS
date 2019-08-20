using MediatR;

namespace Northwind.Application.Queries.GetCustomerList
{
    public class GetNorthwindCustomersListQuery : IRequest<NorthwindCustomersListViewModel>
    {
    }
}
