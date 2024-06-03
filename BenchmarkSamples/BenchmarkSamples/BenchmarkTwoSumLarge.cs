using BenchmarkDotNet.Attributes;

namespace BenchmarkSamples
{
    public class BenchmarkTwoSumLarge
    {
        private readonly int target = 1999;
        private readonly int[] nums;

        public BenchmarkTwoSumLarge()
        {
            nums = new int[1000];
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
                    if (nums[i] + nums[j] == target)
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
                if (nums.Contains(target - num))
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
                if (set.Contains(target - num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
