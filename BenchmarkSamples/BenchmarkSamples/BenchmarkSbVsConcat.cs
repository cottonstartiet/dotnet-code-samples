using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class BenchmarkSbVsConcat
    {
        [Benchmark]
        public string ConcatString()
        {
            string value = "val";
            string result = string.Empty;

            for (int i = 0; i < 1000; i++)
            {
                result += value;
            }

            return result;
        }

        [Benchmark]
        public string ConcatStringBuilder()
        {
            string value = "val";
            StringBuilder result = new();

            for (int i = 0; i < 1000; i++)
            {
                _ = result.Append(value);
            }

            return result.ToString();
        }
    }
}
