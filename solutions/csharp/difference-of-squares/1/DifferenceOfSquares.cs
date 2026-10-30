public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int total = 1;
        for (int i = 2; i <= max; total += i,i++ ){}
        return total * total;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int total = 0;
        for (int i = 1; i <= max; total += i * i,i++ ) { }
        return total;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}