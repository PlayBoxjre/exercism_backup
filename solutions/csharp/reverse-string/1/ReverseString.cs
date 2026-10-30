public static class ReverseString
{
    public static string Reverse(string input)
    {
          return new(input.ToCharArray().Reverse().ToArray());
    }
}