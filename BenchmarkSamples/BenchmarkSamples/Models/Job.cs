namespace BenchmarkSamples.Models
{
    public class Job
    {
        public Job(string id, JobStatus status)
        {
            Id = id;
            Status = status;
        }

        public string Id { get; set; }
        public JobStatus Status { get; set; }
    }
}