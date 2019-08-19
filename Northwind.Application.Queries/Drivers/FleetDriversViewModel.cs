using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.Application.Queries.Drivers
{
    public class FleetDriversViewModel : QueryViewModel
    {
        public IEnumerable<FleetDriverViewDto> Drivers { get; set; }
    }
}
