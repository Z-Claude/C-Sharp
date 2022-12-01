namespace LeetCode
{
    public static class 只出现一次的数字
    {
        public static void Main()
        {
            var nums = new int[] { 4, 1, 2, 1, 2, 3, 3 };
            SingleNumber(nums);
            Console.WriteLine(string.Join(',', nums));
        }
        public static int SingleNumber(int[] nums)
        {
            var result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
