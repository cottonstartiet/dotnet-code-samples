using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class StringBuilderVsConcat
    {
        [Benchmark]
        public void ConcatString()
        {
            string value = "val";
            string result = string.Empty;

            for (int i = 0; i < 1000; i++)
            {
                result += value;
            }
        }

        [Benchmark]
        public void ConcatStringBuilder()
        {
            string value = "val";
            StringBuilder result = new();

            for (int i = 0; i < 1000; i++)
            {
                _ = result.Append(value);
            }
        }
    }
}
