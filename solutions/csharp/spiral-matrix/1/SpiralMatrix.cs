public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var matrix = new int[size, size];
        if (size <= 0) return matrix;

        int top = 0, bottom = size - 1;
        int left = 0, right = size - 1;
        int num = 1;

        while (num <= size * size)
        {
            // 从左到右填充上边
            for (int col = left; col <= right; col++)
                matrix[top, col] = num++;
            top++;

            // 从上到下填充右边
            for (int row = top; row <= bottom; row++)
                matrix[row, right] = num++;
            right--;

            // 从右到左填充下边
            if (top <= bottom)
            {
                for (int col = right; col >= left; col--)
                    matrix[bottom, col] = num++;
                bottom--;
            }

            // 从下到上填充左边
            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                    matrix[row, left] = num++;
                left++;
            }
        }

        return matrix;
    }
}