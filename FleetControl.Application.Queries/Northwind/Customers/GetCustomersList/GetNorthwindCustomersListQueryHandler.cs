using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Northwind.Application.Queries.GetCustomerList;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Queries.GetCustomerList
{
    public class GetNorthwindCustomersListQueryHandler : IRequestHandler<GetNorthwindCustomersListQuery, NorthwindCustomersListViewModel>
    {
        private readonly INorthwindDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFleetControlContext _fleetContext;

        public GetNorthwindCustomersListQueryHandler(INorthwindDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<NorthwindCustomersListViewModel> Handle(GetNorthwindCustomersListQuery request, CancellationToken cancellationToken)
        {
            return new NorthwindCustomersListViewModel
            {
                Customers = await _context.Customers.ProjectTo<NorthwindCustomerLookupModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
