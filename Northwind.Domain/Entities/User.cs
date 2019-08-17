using Northwind.Domain.ValueObjects;

namespace FleetControl.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public AdAccount AdAccount { get; set; }
    }
}
