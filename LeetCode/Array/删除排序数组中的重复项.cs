namespace LeetCode
{
    public static class 删除排序数组中的重复项
    {
        public static void Main()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var s = RemoveDuplicates(nums);
            Console.WriteLine(s);
        }
        public static int RemoveDuplicates(int[] nums)
        {
            var length = 1;
            var result = 0;
            while (nums.Length > length)
            {
                if (nums[length] != nums[result])
                {
                    result++;
                    nums[result] = nums[length];
                }
                length++;
            }
            return ++result;
        }
    }

}
