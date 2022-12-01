namespace LeetCode
{
    public static class 有效的数独
    {
        public static void Main()
        {
            var nums = new char[9][] {
                new char[] {'5','3','.','.','7','.','.','.','.' },
                new char[] {'6','.','.','1','9','5','.','.','.' },
                new char[] {'.','9','8','.','.','.','.','6','.' },
                new char[] {'8','.','.','.','6','.','.','.','3' },
                new char[] { '4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6' },
                new char[] {'.','6','.','.','.','.','2','8','.' },
                new char[] {'.','.','.','4','1','9','.','.','5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' } };
            IsValidSudoku(nums);
            Console.WriteLine();
        }
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                var h = new HashSet<char>();
                var s = new HashSet<char>();
                var b = new HashSet<char>();
                for (int j = 0; j < board[i].Length; j++)
                {
                    //横
                    if (board[i][j] != '.' && !h.Add(board[i][j]))
                    {
                        return false;
                    }
                    //竖
                    if (board[j][i] != '.' && !s.Add(board[j][i]))
                    {
                        return false;
                    }
                    //3x3
                    int a = (i / 3) * 3 + j / 3;
                    int c = (i % 3) * 3 + j % 3;
                    if (board[a][c] != '.' && !b.Add(board[a][c]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
