using MediatR;

namespace FleetControl.Application.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ProductsListViewModel>
    {
    }
}
