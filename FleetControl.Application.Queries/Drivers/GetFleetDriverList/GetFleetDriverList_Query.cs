using FleetControl.Application.Queries.Drivers;
using MediatR;

namespace FleetControl.Application.Queries.Customers.GetFleetCustomer
{
    public class GetFleetDriverListQuery : IRequest<GetFleetDriverList_ViewModel>
    {
        public QueryRequestModel QueryRequest { get; }
        public int Baid { get; }

        public GetFleetDriverListQuery(int baid, QueryRequestModel queryRequest)
        {
            QueryRequest = queryRequest;
            Baid = baid;
        }
    }
}
