using System.Collections.Generic;

namespace Northwind.Application.Queries.GetAllProducts
{
    public class NorthwindProductsListViewModel
    {
        public IEnumerable<ProductDto> Products { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
