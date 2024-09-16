// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Logging;
using MultithreadedListAccess;
using MultithreadedListAccess.Utils;
using System.Collections.Concurrent;
using System.Diagnostics;

ILogger<Program> logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<Program>();

// Get the list of users and evaluate them one by one agains the offers. Measure the time spent and log it.
ConcurrentBag<MultithreadedListAccess.Models.User> users = Helper.GetUsersList();
OfferEligibilityEvaluator evaluator = new();
Stopwatch stopwatch = new();
List<int> userIds = [];

stopwatch.Start();
foreach (MultithreadedListAccess.Models.User user in users)
{
    if (evaluator.Evaluate(user))
    {
        userIds.Add(user.Id);
    }
}
stopwatch.Stop();

logger.LogInformation("Time spent: {timeSpent} ms", stopwatch.ElapsedMilliseconds);
logger.LogInformation("Users eligible for the offer: {numberOfUsers}", userIds.Count);


// Simulate offer evaluation as if each user is coming in a separate request and each request is processed on a separate thread.
// Measure the time spent and log it.
ConcurrentBag<MultithreadedListAccess.Models.User> users2 = Helper.GetUsersList();
OfferEligibilityEvaluator evaluator2 = new();
Stopwatch stopwatch2 = new();
List<int> userIds2 = [];

stopwatch.Start();
Parallel.ForEach(users, user =>
{
    if (evaluator.Evaluate(user))
    {
        userIds2.Add(user.Id);
    }
});
stopwatch.Stop();

logger.LogInformation("Time spent: {timeSpent} ms", stopwatch.ElapsedMilliseconds);
logger.LogInformation("Users eligible for the offer: {numberOfUsers}", userIds2.Count);


