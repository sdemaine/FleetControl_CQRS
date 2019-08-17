using MediatR;

namespace FleetControl.Application.Queries.GetProduct
{
    public class GetProductQuery : IRequest<ProductViewModel>
    {
        public int Id { get; set; }
    }
}
