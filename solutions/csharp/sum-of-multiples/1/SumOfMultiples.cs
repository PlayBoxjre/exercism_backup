public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        // 先过滤掉基数中的0，避免除零异常
        var validBases = multiples.Where(m => m != 0);

        return Enumerable.Range(1, max - 1)
            .Where(num => validBases.Any(basis => num % basis == 0))
            .Distinct()
            .Sum();
    }
}