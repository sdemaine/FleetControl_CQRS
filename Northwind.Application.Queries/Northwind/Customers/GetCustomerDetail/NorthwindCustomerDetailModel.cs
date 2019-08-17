using System;
using System.Linq.Expressions;
using Northwind.Domain.Entities;

namespace Northwind.Application.Queries.GetCustomerDetail
{
    public class NorthwindCustomerDetailModel
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }

        public static Expression<Func<Customer, NorthwindCustomerDetailModel>> Projection
        {
            get
            {
                return customer => new NorthwindCustomerDetailModel
                {
                    Id = customer.CustomerId,
                    Address = customer.Address,
                    City = customer.City,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    ContactTitle = customer.ContactTitle,
                    Country = customer.Country,
                    Fax = customer.Fax,
                    Phone = customer.Phone,
                    PostalCode = customer.PostalCode,
                    Region = customer.Region
                };
            }
        }

        public static NorthwindCustomerDetailModel Create(Customer customer)
        {
            return Projection.Compile().Invoke(customer);
        }
    }
}
