using FleetControl.Application.Queries;
using FleetControl.Application.Queries.Customers.GetFleetCustomer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetCustomers/{baid}/FleetDrivers")]
    public class FleetDriversController : BaseController
    {
        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<ActionResult<FleetDriversViewModel>> GetAll()
        //{
        //    return Ok(await Mediator.Send(new GetFleetDriversQuery { CustomerId } ()));
        //}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<GetFleetCustomerDetailModel>>> Get(int baid)
        {
            return Ok(await Mediator.Send(new GetFleetDriversQuery { Baid = baid }));
        }
    }
}