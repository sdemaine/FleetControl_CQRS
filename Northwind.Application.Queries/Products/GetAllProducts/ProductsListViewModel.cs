using System.Collections.Generic;

namespace FleetControl.Application.Queries.GetAllProducts
{
    public class ProductsListViewModel
    {
        public IEnumerable<ProductDto> Products { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
