using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FleetControl.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using FleetControl.Application.Queries.Customers;

namespace FleetControl.Application.Queries.GetCustomerList
{
    public class GetFleetCustomersListQueryHandler : IRequestHandler<GetFleetCustomersListQuery, FleetCustomersListViewModel>
    {
        private readonly INorthwindDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFleetControlContext _fleetContext;

        public GetFleetCustomersListQueryHandler(INorthwindDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<FleetCustomersListViewModel> Handle(GetFleetCustomersListQuery request, CancellationToken cancellationToken)
        {
            return new FleetCustomersListViewModel
            {
                Customers = await _context.Customers.ProjectTo<FleetCustomerViewModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
