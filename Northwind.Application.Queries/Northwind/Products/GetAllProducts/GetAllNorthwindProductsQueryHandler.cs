using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Dapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FleetControl.Application.Interfaces;
using FleetControl.Infrastructure;

namespace Northwind.Application.Queries.GetAllProducts
{
    public class GetAllNorthwindProductsQueryHandler : IRequestHandler<GetAllNorthwindProductsQuery, NorthwindProductsListViewModel>
    {
        private readonly INorthwindDbContext _context;
        private readonly IMapper _mapper;
        private readonly IOptions<ConnectionStringConfig> _configAccessor;

        public GetAllNorthwindProductsQueryHandler(INorthwindDbContext context, IMapper mapper, IOptions<ConnectionStringConfig> configAccessor)
        {
            _context = context;
            _mapper = mapper;
            _configAccessor = configAccessor;
        }

        public async Task<NorthwindProductsListViewModel> Handle(GetAllNorthwindProductsQuery request, CancellationToken cancellationToken)
        {
            //using (IDbConnection db = new SqlConnection(_configAccessor.Value.NorthwindDatabase))
            //{
            //    var products2 = await db.QueryAsync<ProductDto>("Select ProductId, ProductName, UnitPrice, SupplierId, CategoryId, Discontinued From Products");
            //    var model = new ProductsListViewModel
            //    {
            //        Products = products2,
            //        CreateEnabled = true
            //    };
            //    return model;
            //}

            var product2 = _context.Products.FirstOrDefault();
            ProductDto p2 = _mapper.Map<ProductDto>(product2);

            // TODO: Set view model state based on user permissions.
            var products = await _context.Products.OrderBy(p => p.ProductName).Include(p => p.Supplier).ToListAsync(cancellationToken);

            var model = new NorthwindProductsListViewModel
            {
                Products = _mapper.Map<IEnumerable<ProductDto>>(products),
                CreateEnabled = true
            };

            return model;

        }
    }
}
