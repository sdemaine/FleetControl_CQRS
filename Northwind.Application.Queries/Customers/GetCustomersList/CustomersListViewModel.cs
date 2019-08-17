using System.Collections.Generic;

namespace FleetControl.Application.Queries.GetCustomerList
{
    public class CustomersListViewModel
    {
        public IList<CustomerLookupModel> Customers { get; set; }
    }
}
