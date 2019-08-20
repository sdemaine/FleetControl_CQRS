using Northwind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Queries.Orders.GetCustomerOrders
{
    public class NorthwindCustomerOrderListViewModel
    {
        public NorthwindCustomerOrderListViewModel()
        {
            CustomerOrders = new List<NorthwindOrderDto>();
        }
        public IEnumerable<NorthwindOrderDto> CustomerOrders { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
