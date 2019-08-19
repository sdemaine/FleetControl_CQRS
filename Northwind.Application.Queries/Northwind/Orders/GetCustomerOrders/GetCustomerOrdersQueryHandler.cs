using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FleetControl.Application.Interfaces;
using Northwind.Domain.Entities;
using FleetControl.Infrastructure;

namespace Northwind.Application.Queries.Orders.GetCustomerOrders
{
    public class GetNorthwindCustomerOrdersQueryHandler : IRequestHandler<GetNorthwindCustomerOrdersQuery, NorthwindCustomerOrderListViewModel>
    {
        private readonly INorthwindDbContext _context;
        private readonly IMapper _mapper;
        private readonly IOptions<ConnectionStringConfig> _configAccessor;

        public GetNorthwindCustomerOrdersQueryHandler(INorthwindDbContext context, IMapper mapper, IOptions<ConnectionStringConfig> configAccessor)
        {
            _context = context;
            _mapper = mapper;
            _configAccessor = configAccessor;
        }

        public async Task<NorthwindCustomerOrderListViewModel> Handle(GetNorthwindCustomerOrdersQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.Include(x => x.Orders).FirstOrDefaultAsync(x => x.CustomerId == request.CustomerId);
            var model = new NorthwindCustomerOrderListViewModel()
            {
                CreateEnabled = true,
                CustomerOrders = new List<NorthwindOrderDto>()
            };

            
            if (customer != null)
            {
                model.CustomerOrders = _mapper.Map<IEnumerable<NorthwindOrderDto>>(customer.Orders);
            }

            return model;
        }
    }
}
