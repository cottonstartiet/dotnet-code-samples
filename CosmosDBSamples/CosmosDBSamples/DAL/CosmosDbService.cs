using CosmosDBSamples.DAL.Models;
using Microsoft.Azure.Cosmos;

namespace CosmosDBSamples.DAL
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

        public JobInfo CreateJob(JobInfo jobInfo)
        {
            ItemResponse<JobInfo> response = jobsContainer.UpsertItemAsync(jobInfo, new PartitionKey(jobInfo.id)).Result;
            return response.Resource;
        }

        public JobInfo GetJobData(string jobId)
        {
            ItemResponse<JobInfo> response = jobsContainer.ReadItemAsync<JobInfo>(jobId, new PartitionKey(jobId)).Result;
            return response.Resource;
        }

        public JobStatus SetJobStatus(JobStatus jobStatus, string jobId)
        {
            ItemResponse<JobStatus> response = jobsContainer.UpsertItemAsync(jobStatus, new PartitionKey(jobId)).Result;
            return response.Resource;
        }

        public JobState GetJobStatus(string jobId)
        {
            return jobsContainer.ReadItemAsync<JobStatus>("STATUS", new PartitionKey(jobId)).Result.Resource.Status;
        }
    }
}
