using Microsoft.EntityFrameworkCore;
using Northwind.Persistence.Infrastructure;

namespace FleetControl.Persistence
{
    public class NorthwindDbContextFactory : DesignTimeDbContextFactoryBase<NorthwindDbContext>
    {
        protected override NorthwindDbContext CreateNewInstance(DbContextOptions<NorthwindDbContext> options)
        {
            return new NorthwindDbContext(options);
        }
    }
}
