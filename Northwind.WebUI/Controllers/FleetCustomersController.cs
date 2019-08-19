using FleetControl.Application.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetCustomers")]
    public class FleetCustomersController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<FleetCustomersListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetFleetCustomersListQuery()));
        }

        [HttpGet("{baid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetFleetCustomerDetailModel>> Get(int baid)
        {
            return Ok(await Mediator.Send(new GetFleetCustomerQuery { Baid = baid }));
        }
    }
}