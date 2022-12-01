namespace LeetCode
{
    public static class 旋转图像
    {
        public static void Main()
        {
            var nums = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            Rotate(nums);
            Console.WriteLine();
        }
        public static void Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[j][n - i - 1] = matrix[i][j];
                }
            }
        }
    }
}
