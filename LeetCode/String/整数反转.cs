namespace LeetCode.String
{
    public static class 整数反转
    {
        public static void Main(string[] ages)
        {
            Console.WriteLine(Reverse(-123));
        }
        public static int Reverse(int x)
        {
            var res = 0;
            while (x != 0)
            {
                res = res * 10 + x % 10;
                if (res % 10 != x % 10)
                {
                    return 0;
                }
                x /= 10;
            }
            return res;
        }
    }
}
