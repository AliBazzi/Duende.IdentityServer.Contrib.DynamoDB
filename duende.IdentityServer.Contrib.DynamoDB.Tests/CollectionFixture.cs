using Xunit;

namespace Duende.IdentityServer.Contrib.DynamoDB.Tests
{
    [CollectionDefinition("grant")]
    public class CollectionFixture :
        ICollectionFixture<TestContext>
    {
    }
}