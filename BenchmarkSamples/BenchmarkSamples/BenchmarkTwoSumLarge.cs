using BenchmarkDotNet.Attributes;

namespace BenchmarkSamples
{
    public class BenchmarkTwoSumLarge
    {
        private const int TARGET = 1999;
        private readonly int[] nums = new int[1000];

        public BenchmarkTwoSumLarge()
        {
            for (int i = 0; i < 1000; i++)
            {
                nums[i] = i;
            }
        }

        [Benchmark]
        public bool TwoSumNested()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == TARGET)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        [Benchmark]
        public bool TwoSumContains()
        {
            foreach (int num in nums)
            {
                if (nums.Contains(TARGET - num))
                {
                    return true;
                }
            }

            return false;
        }

        [Benchmark]
        public bool TwoSumMap()
        {
            HashSet<int> set = [];
            foreach (int num in nums)
            {
                if (set.Contains(TARGET - num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
