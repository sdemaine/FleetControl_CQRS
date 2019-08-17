using System.Collections.Generic;
using MediatR;
using FleetControl.Application.Queries.Models;

namespace FleetControl.Application.Queries.Category
{
    public class GetCategoryPreviewQuery : IRequest<List<CategoryPreviewDto>>
    {
        public int CategoryId { get; set; }
    }
}
