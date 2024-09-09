using LoggingSample;
using Microsoft.Extensions.Logging;

ILogger logger = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
}).CreateLogger<LoggingApp>();

var name = "Xbox";

logger.LogInformation(message: string.Concat("Hello developers of ", name));

logger.LogInformation("Hello developers of {name}", name);

logger.LogInformation(message: string.Create(System.Globalization.CultureInfo.InvariantCulture, $"Hello developers of {name}"));