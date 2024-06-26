using CosmosDBSamples.DAL.Models;
using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;

namespace CosmosDBSamples
{
    internal class CosmosDbService
    {
        private readonly Database database;
        private readonly Container jobsContainer;
        public CosmosDbService()
        {
            CosmosClient client = new("");

            database = client.CreateDatabaseIfNotExistsAsync("JobDatabase").Result;
            jobsContainer = database.CreateContainerIfNotExistsAsync("JobContainer", "/pk").Result.Container;
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

        public Task<ItemResponse<JobStatus>> GetJobStatus(string jobId)
        {
            return jobsContainer.ReadItemAsync<JobStatus>("STATUS", new PartitionKey(jobId));
        }
    }
}
