using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class BenchmarkSbVsConcat
    {
        private static readonly int COUNT = 1000; 
        [Benchmark]
        public string ConcatString()
        {
            string value = "val";
            string result = string.Empty;

            for (int i = 0; i < COUNT; i++)
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

            for (int i = 0; i < COUNT; i++)
            {
                result.Append(value);
            }

            return result.ToString();
        }
    }
}
