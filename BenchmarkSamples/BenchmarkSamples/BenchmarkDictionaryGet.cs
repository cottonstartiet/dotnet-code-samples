using BenchmarkDotNet.Attributes;
using BenchmarkSamples.Models;
using System.Collections.Concurrent;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class BenchmarkDictionaryGet
    {
        private List<CustomerClass> customers = [];
        private Dictionary<string, CustomerClass> customersDict = [];
        private ConcurrentDictionary<string, CustomerClass> customersConcurrentDict = [];

        public BenchmarkDictionaryGet()
        {
            SetupData();
        }

        private void SetupData()
        {
            for (int i = 0; i < 1000; i++)
            {
                customers.Add(new CustomerClass
                {
                    Name = "Name" + i,
                    Age = 30,
                    Address = new AddressClass
                    {
                        City = "City",
                        Country = "Country"
                    }
                });
            }

            foreach (var customer in customers)
            {
                customersDict.Add(customer.Name, customer);
                customersConcurrentDict.TryAdd(customer.Name, customer);
            }
        }

        [Benchmark]
        public void DictionaryGet()
        {
            for(int i = 100; i < 200; i++)
            {
                _ = customersDict["Name" + i];
            }
        }

        [Benchmark]
        public void ConcurrentDictionaryGet()
        {
            for(int i = 100; i < 200; i++)
            {
                _ = customersConcurrentDict["Name" + i];
            }   
        }
    }
}
