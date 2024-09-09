using Microsoft.Extensions.Logging;

namespace LoggingSample
{
    internal class LoggingApp
    {
        private readonly ILogger<LoggingApp> logger;

        public LoggingApp(ILogger<LoggingApp> logger)
        {
            this.logger = logger;
        }

        public void Run()
        {
            logger.LogInformation("Hello, World!");
        }
    }
}
