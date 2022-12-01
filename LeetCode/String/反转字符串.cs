namespace LeetCode.String
{
    public static class 反转字符串
    {
        public static void Main(string[] ages)
        {
            var s = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            ReverseString(s);
            Console.WriteLine(s);
        }
        public static void ReverseString(char[] s)
        {
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                (s[i], s[j]) = (s[j], s[i]);
                i++;
                j--;
            }

        }
    }
}
