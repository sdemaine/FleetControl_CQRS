using System.Collections.Generic;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomersList_ViewModel
    {
        public IList<GetFleetCustomer_ViewModel> Customers { get; set; }
    }
}
