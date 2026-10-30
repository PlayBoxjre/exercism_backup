using System.Collections.Generic;

public static class Rectangles
{
   public static int Count(string[] rows)
{
    if (rows is null || rows.Length == 0)
        return 0;

    var corners = new List<(int R, int C)>();
    for (int r = 0; r < rows.Length; r++)
        for (int c = 0; c < rows[r].Length; c++)
            if (rows[r][c] == '+')
                corners.Add((r, c));

    int count = 0;
    foreach (var (r1, c1) in corners)
        foreach (var (r2, c2) in corners)
        {
            // 只处理"左上 → 右下"这一种方向，同时排除同一行/同一列
            if (r1 >= r2 || c1 >= c2) continue;

            if (IsRectangle(rows, r1, c1, r2, c2))
                count++;
        }

    return count;
}

private static bool IsRectangle(string[] rows, int r1, int c1, int r2, int c2)
{
    // 四个角必须都是 '+'
    if (rows[r1][c2] != '+' || rows[r2][c1] != '+') return false;
    
    // 顶边和底边
    for (int c = c1 + 1; c < c2; c++)
    {
        if (c >= rows[r1].Length || c >= rows[r2].Length) return false;
        if (rows[r1][c] != '-' && rows[r1][c] != '+') return false;
        if (rows[r2][c] != '-' && rows[r2][c] != '+') return false;
    }
    // 左边和右边
    for (int r = r1 + 1; r < r2; r++)
    {
        if (c1 >= rows[r].Length || c2 >= rows[r].Length) return false;
        if (rows[r][c1] != '|' && rows[r][c1] != '+') return false;
        if (rows[r][c2] != '|' && rows[r][c2] != '+') return false;
    }
    return true;
}
}