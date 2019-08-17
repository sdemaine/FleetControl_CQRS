using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Orders.GetCustomerOrders
{
    public class CustomerOrderListViewModel
    {
        public CustomerOrderListViewModel()
        {
            CustomerOrders = new List<OrderDto>();
        }
        public IEnumerable<OrderDto> CustomerOrders { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
