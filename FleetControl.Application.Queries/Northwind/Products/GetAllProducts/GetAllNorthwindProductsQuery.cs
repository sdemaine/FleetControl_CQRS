using MediatR;

namespace Northwind.Application.Queries.GetAllProducts
{
    public class GetAllNorthwindProductsQuery : IRequest<NorthwindProductsListViewModel>
    {
    }
}
