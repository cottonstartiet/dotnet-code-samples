namespace CosmosDBSamples.DAL.Models
{
    internal record JobInfo : BaseJobEntity
    {
        public required string JobName { get; init; }
        public required string JobDescription { get; init; }

    }
}
