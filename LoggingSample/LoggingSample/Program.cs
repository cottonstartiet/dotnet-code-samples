using Microsoft.Extensions.Logging;

ILogger logger = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
}).CreateLogger("LogginSampleApp");

var name = "Xbox";
int counter = 1;

logger.LogInformation("Hello developers of {name} with {counter}", name, counter);



