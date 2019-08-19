using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using MediatR;
using Northwind.Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Commands.DeleteCustomer
{
    public class DeleteNorthwindCustomerCommandHandler : IRequestHandler<DeleteNorthwindCustomerCommand>
    {
        private readonly INorthwindDbContext _context;

        public DeleteNorthwindCustomerCommandHandler(INorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteNorthwindCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customers
                .FindAsync(request.CustomerId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Customer), request.CustomerId);
            }

            var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            if (hasOrders)
            {
                // TODO: Add functional test for this behaviour.
                throw new DeleteFailureException(nameof(Customer), request.CustomerId, "There are existing orders associated with this customer.");
            }

            _context.Customers.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
