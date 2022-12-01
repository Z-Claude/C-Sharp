namespace LeetCode
{
    //给你一个整数数组 prices ，其中 prices[i] 表示某支股票第 i 天的价格。
    //在每一天，你可以决定是否购买和/或出售股票。你在任何时候 最多 只能持有 一股 股票。你也可以先购买，然后在 同一天 出售。
    //返回 你能获得的 最大 利润 。
    //作者：力扣(LeetCode)
    //链接：https://leetcode.cn/leetbook/read/top-interview-questions-easy/x2zsx1/
    //来源：力扣（LeetCode）
    //著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
    public static class 买卖股票的最佳时机_II
    {
        public static void Main()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var s = MaxProfit(nums);
            Console.WriteLine(s);
        }
        public static int MaxProfit(int[] prices)
        {
            var result = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                result += Math.Max(prices[i] - prices[i - 1], 0);
            }
            return result;
        }
    }
}
