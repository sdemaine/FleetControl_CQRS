using FleetControl.Application.Queries.Drivers;
using MediatR;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetCustomerDriverListQuery : IRequest<GetFleetCustomerDriverList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }
        public int Baid { get; }

        public GetFleetCustomerDriverListQuery(int baid, QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
            Baid = baid;
        }
    }
}
