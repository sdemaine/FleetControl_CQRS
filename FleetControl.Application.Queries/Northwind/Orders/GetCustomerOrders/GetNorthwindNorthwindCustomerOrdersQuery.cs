using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Queries.Orders.GetCustomerOrders
{
    public class GetNorthwindCustomerOrdersQuery : IRequest<NorthwindCustomerOrderListViewModel>
    {
        public string CustomerId { get; set; }
    }
}
