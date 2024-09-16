using CosmosDBSamples;
using CosmosDBSamples.DAL.Models;
using Microsoft.Extensions.Logging;


var logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<CosmosDbService>();
logger.LogInformation("Running cosmosdb single table design pattern sample");

string JOB_ID = "1";

CosmosDbService service = new();

var createJobResponse = await service.CreateJob(new JobInfo { pk = JOB_ID, id = JOB_ID, JobName = "job-name-1", JobDescription = "job-description-1" });
logger.LogInformation("Create - request charge: {requestCharge}", createJobResponse.RequestCharge);

var readResponse = await service.GetJobData(JOB_ID);
logger.LogInformation("Read - request charge: {requestCharge}", readResponse.RequestCharge);

var setTimeResponse = await service.SetLastRunTime(JOB_ID);
logger.LogInformation("Set last run time - request charge: {requestCharge}", readResponse.RequestCharge);

var readTimeResponse = await service.GetLastRunTime(JOB_ID);
logger.LogInformation("Get lastrunt time read - request charge: {requestCharge}", readTimeResponse.RequestCharge);

//var updateStatusResponse = await service.SetJobStatus(
//    new JobStatus
//    {
//        pk = JOB_ID,
//        id = "STATUS",
//        Status = JobState.CREATED,
//        UpdatedAt = DateTime.Now
//    }, JOB_ID);
//logger.LogInformation(updateStatusResponse.Resource.ToString());
//logger.LogInformation("Update - Request Charge: {requestCharge}", updateStatusResponse.RequestCharge);

//logger.LogInformation((await service.GetJobStatus(JOB_ID)).Resource.ToString());

//var update2 = await service.SetJobStatus(
//    new JobStatus
//    {
//        pk = JOB_ID,
//        id = "STATUS",
//        Status = JobState.INPROGRESS,
//        UpdatedAt = DateTime.Now
//    }, JOB_ID);
//logger.LogInformation((await service.GetJobStatus(JOB_ID)).Resource.ToString());
//logger.LogInformation("Update - Request Charge: {requestCharge}", updateStatusResponse.RequestCharge);