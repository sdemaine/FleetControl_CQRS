using System;
using FleetControl.Persistence;

namespace FleetControl.Application.Tests.Infrastructure
{
    public class CommandTestBase : IDisposable
    {
        protected readonly NorthwindDbContext _context;

        public CommandTestBase()
        {
            _context = NorthwindContextFactory.Create();
        }

        public void Dispose()
        {
            NorthwindContextFactory.Destroy(_context);
        }
    }
}