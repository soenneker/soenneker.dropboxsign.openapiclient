using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.DropboxSign.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class DropboxSignOpenApiClientTests : FixturedUnitTest
{
    public DropboxSignOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
