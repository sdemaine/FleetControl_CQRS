using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Orders.GetCustomerOrders
{
    public class GetCustomerOrdersQuery : IRequest<CustomerOrderListViewModel>
    {
        public string CustomerId { get; set; }
    }
}
