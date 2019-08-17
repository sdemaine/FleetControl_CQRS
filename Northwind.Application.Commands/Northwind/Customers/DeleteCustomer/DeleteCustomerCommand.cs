using MediatR;

namespace Northwind.Application.Commands.DeleteCustomer
{
    public class DeleteNorthwindCustomerCommand : IRequest
    {
        public string Id { get; set; }
    }
}
