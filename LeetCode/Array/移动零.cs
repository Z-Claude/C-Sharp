namespace LeetCode
{
    public static class 移动零
    {
        public static void Main()
        {
            var nums = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            Console.WriteLine(string.Join(',', nums));
        }
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1)
                return;
            var j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[j], nums[i]) = (nums[i], nums[j]);
                    j++;
                }
            }
        }
    }
}
