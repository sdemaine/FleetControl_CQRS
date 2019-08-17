using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FleetControl.Application.Queries.Category;
using FleetControl.Application.Queries.Models;

namespace FleetControl.WebUI.Controllers
{
    public class CategoriesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryPreviewDto>>> GetCategoryPreview([FromQuery] GetCategoryPreviewQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
