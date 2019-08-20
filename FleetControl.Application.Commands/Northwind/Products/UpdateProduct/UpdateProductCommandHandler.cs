using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using Northwind.Domain.Entities;

namespace Northwind.Application.Commands.UpdateProduct
{
    public class UpdateNorthwindProductCommandHandler : IRequestHandler<UpdateNorthwindProductCommand, Unit>
    {
        private readonly INorthwindDbContext _context;

        public UpdateNorthwindProductCommandHandler(INorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateNorthwindProductCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Products.FindAsync(request.ProductId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Product), request.ProductId);
            }

            entity.ProductId = request.ProductId;
            entity.ProductName = request.ProductName;
            entity.CategoryId = request.CategoryId;
            entity.SupplierId = request.SupplierId;
            entity.UnitPrice = request.UnitPrice;
            entity.Discontinued = request.Discontinued;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
