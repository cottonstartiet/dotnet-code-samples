namespace CosmosDBSamples.DAL.Models
{
    internal record LastRunTimeInfo : BaseJobEntity
    {
        public DateTime Value { get; set; }
    }
}
