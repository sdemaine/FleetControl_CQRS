using Northwind.Application.Queries.GetCustomerList;
using System.Collections.Generic;

namespace Northwind.Application.Queries.GetCustomerList
{
    public class NorthwindCustomersListViewModel
    {
        public IList<NorthwindCustomerLookupModel> Customers { get; set; }
    }
}
