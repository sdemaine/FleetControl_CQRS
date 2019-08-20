﻿using MediatR;

namespace Northwind.Application.Commands.CreateProduct
{
    public class CreateNorthwindProductCommand : IRequest<int>
    {
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? SupplierId { get; set; }

        public int? CategoryId { get; set; }

        public bool Discontinued { get; set; }
    }
}