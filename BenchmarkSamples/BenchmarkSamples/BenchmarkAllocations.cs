using BenchmarkDotNet.Attributes;
using BenchmarkSamples.Models;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class BenchmarkAllocations
    {
        [Benchmark]
        public void GetCustomer()
        {
            string dobString = "21 01 2020";

            int dobDate = int.Parse(dobString.Substring(0, 2));
            int dobMonth = int.Parse(dobString.Substring(3, 2));
            int dobYear = int.Parse(dobString.Substring(6));

            CustomerClass customer = new CustomerClass
            {
                Name = "Name",
                Age = 30,
                Address = new AddressClass
                {
                    City = "City",
                    Country = "Country"
                },
                DobDate = dobDate,
                DobMonth = dobMonth,
                DobYear = dobYear
            };
        }

        [Benchmark]
        public void GetCustomerSpan()
        {
            ReadOnlySpan<char> dobSpan = "21 01 2020";
            
            int dobDate = int.Parse(dobSpan.Slice(0, 2));
            int dobMonth = int.Parse(dobSpan.Slice(3, 2));
            int dobYear = int.Parse(dobSpan.Slice(6));

            CustomerClass customer = new()
            {
                Name = "Name",
                Age = 30,
                Address = new AddressClass
                {
                    City = "City",
                    Country = "Country"
                },
                DobDate = dobDate,
                DobMonth = dobMonth,
                DobYear = dobYear
            };
        }
    }
}
