using System.Collections.Generic;

public static class PythagoreanTriplet{

    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var result = new List<(int, int, int)>();

        // a 最小，a < b < c，所以 a 最多 sum/3
        for (int a = 1; a < sum / 3; a++)
        {
            // a+b+c = sum → c = sum - a - b
            // a < b < c → b > a，且 b < (sum - a)/2
            for (int b = a + 1; 2 * b < (sum - a) ; b++)
            {
                int c = sum - a - b;
                if (a * a + b * b == c * c)
                {
                    result.Add((a, b, c));
                }
            }
        }
        return result.ToArray();
    }
}
