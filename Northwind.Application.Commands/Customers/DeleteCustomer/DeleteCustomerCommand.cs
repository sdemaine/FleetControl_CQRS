using MediatR;

namespace FleetControl.Application.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest
    {
        public string Id { get; set; }
    }
}
