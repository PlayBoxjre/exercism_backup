using System;
using System.Collections.Generic;
using System.Linq;
// AI Generate 
// look not understand, what are you say?
// i just learn syntx ,not learn math or 算法 and 光学原理折射
public static class Prism
{
    public readonly record struct LaserInfo(double X, double Y, double Angle);
    public readonly record struct PrismInfo(int Id, double X, double Y, double Angle);

    public static int[] FindSequence(LaserInfo laser, PrismInfo[] prisms)
    {
        var sequence = new List<int>();
        var visited = new HashSet<(int Id, double Angle)>();

        double x = laser.X;
        double y = laser.Y;
        double angle = laser.Angle;

        while (true)
        {
            double rad = angle * Math.PI / 180.0;
            double cos = Math.Cos(rad);
            double sin = Math.Sin(rad);

            PrismInfo? next = null;
            double bestAlong = double.MaxValue;

            foreach (var p in prisms)
            {
                double dx = p.X - x;
                double dy = p.Y - y;
                double distance = Math.Sqrt(dx * dx + dy * dy);

                // 跳过当前位置的棱镜（距离为 0）
                if (distance < 1e-9) continue;

                // 垂直距离（叉积绝对值）
                double perp = Math.Abs(dx * sin - dy * cos);

                // 容差：坐标精度 0.1，取 0.15 足以容纳舍入误差
                if (perp > 0.15) continue;

                // 沿射线方向的距离（点积）
                double along = dx * cos + dy * sin;
                if (along <= 0) continue;

                if (along < bestAlong)
                {
                    bestAlong = along;
                    next = p;
                }
            }

            if (next is null) break;

            sequence.Add(next.Value.Id);
            x = next.Value.X;
            y = next.Value.Y;
            angle += next.Value.Angle;

            // 循环检测：同一棱镜以相同归一化方向再次命中则停止
            double normalized = ((angle % 360) + 360) % 360;
            if (!visited.Add((next.Value.Id, normalized)))
                break;
        }

        return sequence.ToArray();
    }
}