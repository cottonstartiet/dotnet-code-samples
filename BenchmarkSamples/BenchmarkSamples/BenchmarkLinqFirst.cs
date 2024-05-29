using BenchmarkDotNet.Attributes;
using BenchmarkSamples.Models;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class BenchmarkLinqFirst
    {
        private IList<Job> JobsList
        {
            get
            {
                var jobs = new List<Job>
            {
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING),
                new Job(Guid.NewGuid().ToString(), JobStatus.RUNNING),
                new Job(Guid.NewGuid().ToString(), JobStatus.COMPLETED),
                new Job(Guid.NewGuid().ToString(), JobStatus.PENDING)
            };
                return jobs;
            }
        }

        [Benchmark]
        public Job PrintFirstJobWithStatusLinq()
        {
            return JobsList.First(j => j.Status == JobStatus.RUNNING);
        }

        [Benchmark]
        public Job? PrintFirstJobWithRunningStatusForEach()
        {
            foreach (var job in JobsList)
            {
                if (job.Status == JobStatus.RUNNING)
                {
                    return job;
                }
            }

            return null;
        }

        [Benchmark]
        public Job? PrintFirstJobWithRunningStatusForLoop()
        {
            for (int i = 0; i < JobsList.Count; i++)
            {
                if (JobsList[i].Status == JobStatus.RUNNING)
                {
                    return JobsList[i];
                }
            }

            return null;
        }
    }
}
