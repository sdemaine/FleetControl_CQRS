using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerQueryHandler : IRequestHandler<GetFleetCustomerQuery, GetFleetCustomerViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomerQueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCustomerViewModel> Handle(GetFleetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.BAID == request.Baid);
            
            return new GetFleetCustomerViewModel
            {
                Customer = _mapper.Map<FleetCustomerViewDto>(customer)
            };
        }
    }
}
