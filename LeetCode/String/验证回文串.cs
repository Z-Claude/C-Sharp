namespace LeetCode.String
{
    public static class 验证回文串
    {
        //如果在将所有大写字符转换为小写字符、并移除所有非字母数字字符之后，短语正着读和反着读都一样。则可以认为该短语是一个 回文串 。
        //字母和数字都属于字母数字字符。
        //给你一个字符串 s，如果它是 回文串 ，返回 true ；否则，返回 false 。
        //作者：力扣(LeetCode)
        //链接：https://leetcode.cn/leetbook/read/top-interview-questions-easy/xne8id/
        //来源：力扣（LeetCode）
        //著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
        public static void Main(string[] ages)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
