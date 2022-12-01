namespace LeetCode.String
{
    public static class 字符串中的第一个唯一字符
    {
        //给定一个字符串 s ，找到 它的第一个不重复的字符，并返回它的索引 。如果不存在，则返回 -1 。
        public static void Main(string[] ages)
        {
            Console.WriteLine(FirstUniqChar("qerqe"));
        }
        public static int FirstUniqChar(string s)
        {
            var hash = new int[26];
            foreach (var item in s)
            {
                hash[item - 'a']++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (hash[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
