using AutoMapper;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries.Drivers;
using FleetControl.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetDriversQueryHandler : IRequestHandler<GetFleetDriversQuery, FleetDriversViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetDriversQueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<FleetDriversViewModel> Handle(GetFleetDriversQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.BAID == request.Baid);

            var drivers = new List<Driver>();

            if (customer != null)
            {
                drivers = await _context.Driver.Where(x => x.CustomerId == customer.Id).ToListAsync();
            }

            return new FleetDriversViewModel
            {
                RecordCount = drivers.Count,
                Drivers = _mapper.Map<IEnumerable<FleetDriverViewDto>>(drivers)
            };
        }
    }
}
