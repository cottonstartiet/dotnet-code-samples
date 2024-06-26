﻿using CosmosDBSamples;
using CosmosDBSamples.DAL.Models;

Console.WriteLine("Running cosmosdb single table design pattern sample");

string JOB_ID = "1";

CosmosDbService service = new();

await service.CreateJob(new JobInfo { pk = JOB_ID, id = JOB_ID, JobName = "job-name-1", JobDescription = "job-description-1" });

Console.WriteLine((await service.GetJobData(JOB_ID)).Resource);

var updateStatusResponse = await service.SetJobStatus(
    new JobStatus
    {
        pk = JOB_ID,
        id = "STATUS",
        Status = JobState.CREATED,
        UpdatedAt = DateTime.Now
    }, JOB_ID);
Console.WriteLine(updateStatusResponse.Resource);

Console.WriteLine((await service.GetJobStatus(JOB_ID)).Resource);

var update2 = await service.SetJobStatus(
    new JobStatus
    {
        pk = JOB_ID,
        id = "STATUS",
        Status = JobState.INPROGRESS,
        UpdatedAt = DateTime.Now
    }, JOB_ID);
Console.WriteLine(update2.Resource);

Console.WriteLine((await service.GetJobStatus(JOB_ID)).Resource);
