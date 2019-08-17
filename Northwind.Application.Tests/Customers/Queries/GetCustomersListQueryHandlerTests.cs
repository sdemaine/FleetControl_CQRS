using AutoMapper;
using FleetControl.Application.Queries.GetCustomerList;
using FleetControl.Application.Tests.Infrastructure;
using FleetControl.Persistence;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FleetControlTraders.Application.UnitTests.Infrastructure
{
    [Collection("QueryCollection")]
    public class GetCustomersListQueryHandlerTests
    {
        private readonly NorthwindDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersListQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
        }

        [Fact]
        public async Task GetCustomersTest()
        {
            var sut = new GetCustomersListQueryHandler(_context, _mapper);

            var result = await sut.Handle(new GetCustomersListQuery(), CancellationToken.None);

            result.ShouldBeOfType<CustomersListViewModel>();

            result.Customers.Count.ShouldBe(3);
        }
    }
}