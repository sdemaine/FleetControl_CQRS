using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class GetFleetDriverList_ViewModel : QueryViewModel
    {
        public IEnumerable<GetFleetDriverList_ViewDto> Drivers { get; }

        public GetFleetDriverList_ViewModel(int recordCount, string previousPage, string nextPage, IEnumerable<GetFleetDriverList_ViewDto> drivers) : base(recordCount, previousPage, nextPage)
        {
            Drivers = drivers;
        }
    }
}
