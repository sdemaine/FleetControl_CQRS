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
    public class GetFleetCustomersListQueryHandler : IRequestHandler<GetFleetCustomersListQuery, FleetCustomersListViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomersListQueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<FleetCustomersListViewModel> Handle(GetFleetCustomersListQuery request, CancellationToken cancellationToken)
        {
            var cards = await _context.Card.Take(10).ToListAsync();
            //var customers = await _context.Customer.ToListAsync();


            return new FleetCustomersListViewModel
            {
                Customers = await _context.Customer.ProjectTo<FleetCustomerViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
