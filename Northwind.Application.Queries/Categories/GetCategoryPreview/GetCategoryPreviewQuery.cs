using System.Collections.Generic;
using MediatR;
using Northwind.Application.Queries.Models;

namespace FleetControl.Application.Queries.Category
{
    public class GetCategoryPreviewQuery : IRequest<List<CategoryPreviewDto>>
    {
        public int CategoryId { get; set; }
    }
}
