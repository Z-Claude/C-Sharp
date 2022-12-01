namespace LeetCode.String
{
    public static class 最长公共前缀
    {
        public static void Main(string[] ages)
        {
            var arr = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(arr));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            var str = strs[0];
            var res = "";
            for (int i = 0; i < str.Length; i++)
            {
                var s = str[i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j].Length <= i || strs[j][i] != s)
                    {
                        return res;
                    }
                }
                res += str[i];
            }
            return res;
        }

    }
}
