using BenchmarkDotNet.Attributes;
using System.Collections.Concurrent;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class BenchmarkDictionaries
    {
        [Benchmark]
        public void BenchmarkDictionary()
        {
            var dict = new Dictionary<string, CustomerRecord>();
            for (int i = 0; i < 10000; i++)
            {
                var name = "Name" + i;
                dict.Add(name, new CustomerRecord
                {
                    Name = name,
                    Age = 30,
                    Address = new AddressRecord
                    {
                        City = "City",
                        Country = "Country"
                    }
                });
            }

        }

        [Benchmark]
        public void BenchmarkConcurrentDictionary()
        {
            var dict = new ConcurrentDictionary<string, CustomerRecord>();
            for (int i = 0; i < 10000; i++)
            {
                var name = "Name" + i;
                dict.TryAdd(name, new CustomerRecord
                {
                    Name = name,
                    Age = 30,
                    Address = new AddressRecord
                    {
                        City = "City",
                        Country = "Country"
                    }
                });
            }
        }
    }
}
