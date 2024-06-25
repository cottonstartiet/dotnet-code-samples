namespace CosmosDBSamples.DAL.Models
{
    internal record JobStatus : BaseJobEntity
    {
        public JobState Status { get; init; } = JobState.CREATED;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
