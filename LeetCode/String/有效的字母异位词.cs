namespace LeetCode.String
{
    public static class 有效的字母异位词
    {
        public static void Main(string[] ages)
        {
            Console.WriteLine(IsAnagram("qerqe", "qqeer"));
        }
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            var hash = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                hash[s[i] - 'a']++;
                hash[t[i] - 'a']--;
            }
            for (int i = 0; i < hash.Length; i++)
            {
                if (hash[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
