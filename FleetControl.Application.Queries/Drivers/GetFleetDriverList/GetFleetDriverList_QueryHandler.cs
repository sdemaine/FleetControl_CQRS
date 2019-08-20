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
    public class GetFleetDriverList_QueryHandler : IRequestHandler<GetFleetDriverListQuery, GetFleetDriverList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetDriverList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetDriverList_ViewModel> Handle(GetFleetDriverListQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.BAID == request.Baid);

            var drivers = new List<Driver>();

            if (customer != null)
            {
                drivers = await _context.Driver.Where(x => x.CustomerId == customer.Id).ToListAsync();
            }

            return new GetFleetDriverList_ViewModel
            {
                RecordCount = drivers.Count,
                Drivers = _mapper.Map<IEnumerable<GetFleetDriverList_ViewDto>>(drivers)
            };
        }
    }
}
