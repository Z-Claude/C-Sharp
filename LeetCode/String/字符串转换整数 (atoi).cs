namespace LeetCode.String
{
    public static class 字符串转换整数
    {
        public static void Main(string[] ages)
        {
            Console.WriteLine(MyAtoi(" -9 5 "));
        }
        public static int MyAtoi(string s)
        {
            s = s.Trim();
            var result = 0;
            var sign = 1;
            var index = 0;
            if (s.Length <= 0)
            {
                return result;
            }
            if (s[index] == '-' || s[index] == '+')
            {
                sign = s[index] == '-' ? -1 : 1;
                index = 1;
            }
            for (int i = index; i < s.Length; i++)
            {
                var res = s[i] - '0';
                if (res > 9 || res < 0)
                {
                    return result * sign;
                }
                var temp = result;
                result = result * 10 + res;
                // 越界
                if (result / 10 != temp)
                {
                    if (sign > 0)
                    {
                        return int.MaxValue;
                    }
                    else
                    {
                        return int.MinValue;
                    }
                }
            }
            return result * sign;
        }
    }
}
