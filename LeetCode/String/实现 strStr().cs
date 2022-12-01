namespace LeetCode.String
{
    public static class 实现strStr
    {
        //给你两个字符串 haystack 和 needle ，
        //请你在 haystack 字符串中找出 needle 字符串的第一个匹配项的下标（下标从 0 开始）。
        //如果 needle 不是 haystack 的一部分，则返回  -1 。

        public static void Main(string[] ages)
        {
            Console.WriteLine(StrStr("a", "a"));
        }
        public static int StrStr(string haystack, string needle)
        {
            var window = needle.Length;
            for (int i = 0; i <= haystack.Length - window; i++)
            {
                if (needle == haystack.Substring(i, window))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
