using FleetControl.Application.Queries.Customers;
using System.Collections.Generic;

namespace FleetControl.Application.Queries.GetCustomerList
{
    public class FleetCustomersListViewModel
    {
        public IList<FleetCustomerViewModel> Customers { get; set; }
    }
}
