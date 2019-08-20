using System.Collections.Generic;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomersList_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetCustomerList_Dto> Customers { get; set; }
    }
}
