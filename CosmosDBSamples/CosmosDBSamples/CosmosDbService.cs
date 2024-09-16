using CosmosDBSamples.DAL.Models;
using Microsoft.Azure.Cosmos;

namespace CosmosDBSamples
{
    internal class CosmosDbService
    {
        private readonly Database database;
        private readonly Container jobsContainer;
        public CosmosDbService()
        {
            CosmosClient client = new("");

            database = client.CreateDatabaseIfNotExistsAsync("JobsDatabase").Result;
            jobsContainer = database.CreateContainerIfNotExistsAsync("JobsContainer", "/pk").Result.Container;
        }

        public async Task<ItemResponse<JobInfo>> CreateJob(JobInfo jobInfo)
        {
            return await jobsContainer.UpsertItemAsync(jobInfo, new PartitionKey(jobInfo.id));
        }

        public Task<ItemResponse<JobInfo>> GetJobData(string jobId)
        {
            return jobsContainer.ReadItemAsync<JobInfo>(jobId, new PartitionKey(jobId));
        }

        public Task<ItemResponse<JobStatus>> SetJobStatus(JobStatus jobStatus, string jobId)
        {
            return jobsContainer.UpsertItemAsync(jobStatus, new PartitionKey(jobId));
        }

        // Inset and item in cosmosdb container where the partition key is the string jobId, Id is the string "LasRunTime" and the value is the current time
        public Task<ItemResponse<LastRunTimeInfo>> SetLastRunTime(string jobId)
        {
            var item = new LastRunTimeInfo
            {
                id = "LastRunTime",
                pk = jobId,
                Value = DateTime.Now
            };

            return jobsContainer.UpsertItemAsync(item, new PartitionKey(jobId));
        }

        public Task<ItemResponse<LastRunTimeInfo>> GetLastRunTime(string jobId)
        {
            return jobsContainer.ReadItemAsync<LastRunTimeInfo>("LastRunTime", new PartitionKey(jobId));
        }

        public Task<ItemResponse<JobStatus>> GetJobStatus(string jobId)
        {
            return jobsContainer.ReadItemAsync<JobStatus>("STATUS", new PartitionKey(jobId));
        }
    }
}
