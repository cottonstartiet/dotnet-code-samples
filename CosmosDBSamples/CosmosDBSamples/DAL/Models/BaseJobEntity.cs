namespace CosmosDBSamples.DAL.Models
{
    internal record BaseJobEntity
    {
        public required string id { get; init; }
        public required string pk { get; init; }
    }
}
