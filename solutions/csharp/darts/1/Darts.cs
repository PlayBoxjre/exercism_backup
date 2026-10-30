public static class Darts
{
    public static int Score(double x, double y) => (x * x + y * y) switch
    {
        > 100d => 0,
        > 25d => 1,
        > 1d => 5,
        _ =>  10
    };
}
