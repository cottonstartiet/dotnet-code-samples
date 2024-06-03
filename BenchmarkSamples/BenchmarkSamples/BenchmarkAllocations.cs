using BenchmarkDotNet.Attributes;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class BenchmarkAllocations
    {
        [Benchmark]
        public void GetCustomer()
        {
            string dobString = "21 01 2020";

            for (int i = 0; i < 1000; i++)
            {
                _ = int.Parse(dobString[..2]);
                _ = int.Parse(dobString.Substring(3, 2));
                _ = int.Parse(dobString[6..]);
            }
        }

        [Benchmark]
        public void GetCustomerSpan()
        {
            ReadOnlySpan<char> dobSpan = "21 01 2020";

            for (int i = 0; i < 1000; i++)
            {
                _ = int.Parse(dobSpan[..2]);
                _ = int.Parse(dobSpan.Slice(3, 2));
                _ = int.Parse(dobSpan[6..]);
            }
        }
    }
}
