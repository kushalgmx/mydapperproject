using FileTransfer.Console;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace FileTransfer.Xunit;
public class DataServiceTests : IDisposable
{
    DataService service;
    public DataServiceTests()
    {
        var log = Mock.Of<ILogger<DataService>>();
        var inMemorySettings = new Dictionary<string, string> {
            {"TopLevelKey", "TopLevelValue"},
            {"ConnectionStrings:DefaultConnection", "DataSource:app.db;Cache=Shared"},
        };
        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(inMemorySettings)
            .Build();
        service = new(log, configuration);
    }
    public void Dispose()
    {
        service.Dispose();
    }

    [Fact]
    public void TestFreebie() => Assert.NotNull(service);

    [Fact]
    public void TestConnect() => service.Connect();
}
