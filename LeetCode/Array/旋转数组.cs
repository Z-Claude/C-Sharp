namespace LeetCode
{
    public static class 旋转数组
    {
        public static void Main()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var k = 3;
            Rotate(nums, k);
            Console.WriteLine(string.Join(',', nums));
        }
        public static void Rotate(int[] nums, int k)
        {
            var length = nums.Length;
            var temp = new int[length];
            for (int i = 0; i < length; i++)
            {
                temp[(i + k) % length] = nums[i];
            }
            Array.Copy(temp, 0, nums, 0, length);
        }
    }
}
