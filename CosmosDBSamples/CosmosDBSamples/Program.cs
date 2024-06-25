// See https://aka.ms/new-console-template for more information
using CosmosDBSamples.DAL;
using CosmosDBSamples.DAL.Models;

Console.WriteLine("Running cosmosdb single table design pattern sample");

string JOB_ID = "1";

CosmosDbService service = new();
service.CreateJob(new JobInfo { pk = JOB_ID, id = JOB_ID, JobName = "job-name-1", JobDescription = "job-description-1" });

Console.WriteLine(service.GetJobData(JOB_ID));

Console.WriteLine(service.SetJobStatus(
    new JobStatus
    {
        pk = JOB_ID,
        id = "STATUS",
        Status = JobState.CREATED,
        UpdatedAt = DateTime.Now
    }, JOB_ID));

Console.WriteLine(service.GetJobStatus(JOB_ID)); ;

Console.WriteLine(service.SetJobStatus(
    new JobStatus
    {
        pk = JOB_ID,
        id = "STATUS",
        Status = JobState.INPROGRESS,
        UpdatedAt = DateTime.Now
    }, JOB_ID)); ;

Console.WriteLine(service.GetJobStatus(JOB_ID)); ;
