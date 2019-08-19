using System;
using System.Linq.Expressions;
using FleetControl.Domain;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetailModel
    {
        public int Id { get; set; }
        

        public static Expression<Func<Customer, GetFleetCustomerDetailModel>> Projection
        {
            get
            {
                return customer => new GetFleetCustomerDetailModel
                {
                    Id = customer.Id
                };
            }
        }

        public static GetFleetCustomerDetailModel Create(Customer customer)
        {
            return Projection.Compile().Invoke(customer);
        }
    }
}
