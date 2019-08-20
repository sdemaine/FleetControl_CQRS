using AutoMapper;
using FleetControl.Application.Interfaces.Mapping;
using Northwind.Domain.Entities;

namespace Northwind.Application.Queries.GetCustomerList
{
    public class NorthwindCustomerLookupModel : IHaveCustomMapping
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Customer, NorthwindCustomerLookupModel>()
                .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.CustomerId))
                .ForMember(cDTO => cDTO.Name, opt => opt.MapFrom(c => c.CompanyName));
        }
    }
}
