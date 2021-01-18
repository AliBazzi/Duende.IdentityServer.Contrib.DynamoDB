using System.Threading.Tasks;
using Xunit;

namespace Duende.IdentityServer.Contrib.DynamoDB.Tests
{
    public class TestContext : IAsyncLifetime
    {
        private readonly TableSetup table;
        public TestContext()
        {
            this.table = new TableSetup();
        }

        public async Task InitializeAsync()
        {
            await table.CreateTable();
        }
        public async Task DisposeAsync()
        {
            await table.DeleteTable();
        }
    }
}