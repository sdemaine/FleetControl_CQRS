using MediatR;

namespace Northwind.Application.Commands.DeleteProduct
{
    public class DeleteNorthwindProductCommand : IRequest
    {
        public int Id { get; set; }
    }
}
