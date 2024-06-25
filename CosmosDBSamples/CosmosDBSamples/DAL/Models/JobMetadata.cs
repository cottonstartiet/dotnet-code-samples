namespace CosmosDBSamples.DAL.Models
{
    internal class JobMetadata<T>
    {
        public required T Data { get; set; }
    }
}
