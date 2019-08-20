﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetControl.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomersList_QueryHandler : IRequestHandler<GetFleetCustomersList_Query, GetFleetCustomersList_ViewModel>
    {
        private readonly IFleetControlDbContext _context;
        private readonly IMapper _mapper;

        public GetFleetCustomersList_QueryHandler(IFleetControlDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetFleetCustomersList_ViewModel> Handle(GetFleetCustomersList_Query request, CancellationToken cancellationToken)
        {
            var cards = await _context.Card.Take(10).ToListAsync();
            var customers = await _context.Customer.OrderBy(x => x.CustomerName).ToListAsync();


            return new GetFleetCustomersList_ViewModel
            {
                RecordCount = customers.Count,
                Customers = _mapper.Map<IEnumerable<GetFleetCustomerList_Dto>>(customers)
                //Customers = await _context.Customer.ProjectTo<GetFleetCustomerList_Dto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}