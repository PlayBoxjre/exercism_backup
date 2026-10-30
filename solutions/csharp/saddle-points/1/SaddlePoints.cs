using System.Collections.Generic;

public static class SaddlePoints
{
    public static IEnumerable<(int row, int col)> Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // 预先计算每一行的最大值
        int[] rowMax = new int[rows];
        for (int r = 0; r < rows; r++)
        {
            int max = int.MinValue;
            for (int c = 0; c < cols; c++)
            {
                if (matrix[r, c] > max)
                    max = matrix[r, c];
            }
            rowMax[r] = max;
        }

        // 预先计算每一列的最小值
        int[] colMin = new int[cols];
        for (int c = 0; c < cols; c++)
        {
            int min = int.MaxValue;
            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, c] < min)
                    min = matrix[r, c];
            }
            colMin[c] = min;
        }

        // 遍历所有单元格判断
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int val = matrix[r, c];
                if (val == rowMax[r] && val == colMin[c])
                {
                    // 题目要求：行、列从1开始计数
                    yield return (r + 1, c + 1);
                }
            }
        }
    }
}
