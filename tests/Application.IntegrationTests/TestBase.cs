using NUnit.Framework;
using static ProjectX.Application.IntegrationTests.Testing;

namespace ProjectX.Application.IntegrationTests;

public class TestBase
{
    [SetUp]
    public async Task TestSetUp()
    {
        await ResetState();
    }
}
