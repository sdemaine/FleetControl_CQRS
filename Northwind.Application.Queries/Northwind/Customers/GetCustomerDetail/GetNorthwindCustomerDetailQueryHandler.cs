using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using Northwind.Domain.Entities;
using Northwind.Application.Queries.GetCustomerDetail;

namespace Northwind.Application.Queries.GetCustomerDetail
{
    public class GetNorthwindCustomerDetailQueryHandler : IRequestHandler<GetNorthwindCustomerDetailQuery, NorthwindCustomerDetailModel>
    {
        private readonly INorthwindDbContext _context;

        public GetNorthwindCustomerDetailQueryHandler(INorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<NorthwindCustomerDetailModel> Handle(GetNorthwindCustomerDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customers
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Customer), request.Id);
            }

            return NorthwindCustomerDetailModel.Create(entity);
        }
    }
}
