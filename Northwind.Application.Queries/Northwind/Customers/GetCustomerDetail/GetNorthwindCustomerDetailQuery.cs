using MediatR;

namespace Northwind.Application.Queries.GetCustomerDetail
{
    public class GetNorthwindCustomerDetailQuery : IRequest<NorthwindCustomerDetailModel>
    {
        public string Id { get; set; }
    }
}
