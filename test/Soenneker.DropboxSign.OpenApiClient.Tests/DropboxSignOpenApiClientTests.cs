using Soenneker.Tests.HostedUnit;

namespace Soenneker.DropboxSign.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DropboxSignOpenApiClientTests : HostedUnitTest
{
    public DropboxSignOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
