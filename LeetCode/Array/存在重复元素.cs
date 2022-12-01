namespace LeetCode
{
    public static class 存在重复元素
    {
        public static void Main()
        {
            var nums = new int[] { 2, 14, 18, 22, 21 };
            var d = ContainsDuplicate1(nums);
            Console.WriteLine(d);
            Console.WriteLine(ContainsDuplicate(nums));
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            var values = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!values.Add(nums[i]))
                {
                    return true;
                }
            }
            return false;
        }
        //双指针
        public static bool ContainsDuplicate1(int[] nums)
        {
            var last = 0;
            var fast = nums.Length - 1;
            var k = 1;
            while (k != nums.Length)
            {
                if (nums[last] == nums[fast])
                {
                    return true;
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
            return false;
        }
    }
}
