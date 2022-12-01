namespace LeetCode
{
    public static class 加一
    {
        public static void Main()
        {
            var nums = new int[] { 0 };
            PlusOne(nums);
            Console.WriteLine(PlusOne(nums));
        }
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }
            var ints = new int[digits.Length + 1];
            ints[0] = 1;
            return ints;
        }
    }
}
