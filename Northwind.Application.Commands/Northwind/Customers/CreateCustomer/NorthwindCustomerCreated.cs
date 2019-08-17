using MediatR;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.Commands.CreateCustomer
{
    public class NorthwindCustomerCreated : INotification
    {
        public string CustomerId { get; set; }

        public class CustomerCreatedHandler : INotificationHandler<NorthwindCustomerCreated>
        {
            private readonly INotificationService _notification;

            public CustomerCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(NorthwindCustomerCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
