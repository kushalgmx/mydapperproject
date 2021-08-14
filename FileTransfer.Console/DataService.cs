using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FileTransfer.Console
{
    public class DataService: IDataService, IDisposable
    {
        private readonly ILogger<DataService> _log;
        private readonly IConfiguration _config;

        public DataService(
            ILogger<DataService> log,
            IConfiguration config
        )
        {
            _log = log;
            _config = config;
        }

        public void Connect()
        {
            // Reading connection string
            var cs = _config.GetValue<string>("ConnectionStrings:DefaultConnection");
            _log.LogInformation($"TODO: Write code to connect to Connection String {cs}");
        }

        public void Disconnect()
        {
            // Reading connection string
            var cs = _config.GetValue<string>("ConnectionStrings:DefaultConnection");
            _log.LogDebug($"TODO: Write code to disconnect from Connection String {cs} here.");
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}
