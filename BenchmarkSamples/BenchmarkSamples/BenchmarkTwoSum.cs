using BenchmarkDotNet.Attributes;

namespace BenchmarkSamples
{
    public class BenchmarkTwoSum
    {
        private readonly int target = 8;
        private readonly int[] nums = [2, 7, 11, 15, 3, 5, 6];

        [Benchmark]
        public bool TwoSumNested()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
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
            var set = new HashSet<int>();
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
