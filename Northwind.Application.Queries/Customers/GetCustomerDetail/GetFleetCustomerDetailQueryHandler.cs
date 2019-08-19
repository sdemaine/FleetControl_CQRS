using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FleetControl.Application.Exceptions;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetailQueryHandler : IRequestHandler<GetFleetCustomerDetailQuery, GetFleetCustomerDetailModel>
    {
        private readonly IFleetControlDbContext _context;

        public GetFleetCustomerDetailQueryHandler(IFleetControlDbContext context)
        {
            _context = context;
        }

        public async Task<GetFleetCustomerDetailModel> Handle(GetFleetCustomerDetailQuery request, CancellationToken cancellationToken)
        {
            //var entity = await _context.Customer
            //    .FindAsync(request.Id);

            //if (entity == null)
            //{
            //    throw new NotFoundException(nameof(Customer), request.Id);
            //}

            //return FleetCustomerDetailModel.Create(entity);
            return null;
        }
    }
}
