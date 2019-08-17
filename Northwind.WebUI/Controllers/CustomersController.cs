using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FleetControl.Application.Commands.CreateCustomer;
using FleetControl.Application.Commands.DeleteCustomer;
using FleetControl.Application.Commands.UpdateCustomer;
using FleetControl.Application.Queries.GetCustomerDetail;
using FleetControl.Application.Queries.GetCustomerList;
using FleetControl.Application.Queries.Orders.GetCustomerOrders;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/Customers")]
    public class CustomersController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CustomersListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetCustomersListQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CustomerDetailModel>> Get(string id)
        {
            return Ok(await Mediator.Send(new GetCustomerDetailQuery { Id = id }));
        }

        [HttpGet]
        [Route("{customerId}/orders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CustomerOrderListViewModel>> GetOrders(string customerId)
        {
            return Ok(await Mediator.Send(new GetCustomerOrdersQuery { CustomerId = customerId }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreateCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody]UpdateCustomerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id)
        {
            await Mediator.Send(new DeleteCustomerCommand { Id = id });

            return NoContent();
        }
    }
}