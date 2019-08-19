using MediatR;

namespace FleetControl.Application.Queries
{
    public class GetFleetCustomerDetailQuery : IRequest<GetFleetCustomerDetailModel>
    {
        public string Id { get; set; }
    }
}
