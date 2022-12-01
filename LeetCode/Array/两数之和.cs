namespace LeetCode
{
    public static class 两数之和
    {
        public static void Main()
        {
            var nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            var ints = TwoSum1(nums, 8);
            Console.WriteLine(string.Join(',', ints));
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            var last = 0;
            var fast = nums.Length - 1;
            var k = 1;
            while (k != nums.Length)
            {
                if (nums[last] + nums[fast] == target)
                {
                    return new int[] { last, fast };
                }
                else
                {
                    fast--;
                }
                if (fast <= last)
                {
                    last = k;
                    fast = nums.Length - 1;
                    k++;
                }
            }
            return Array.Empty<int>();
        }

        public static int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(target - nums[i]))
                {
                    return new int[] { result[target - nums[i]], i };
                }
                result.TryAdd(nums[i], i);
            }
            return Array.Empty<int>();
        }
    }
}
