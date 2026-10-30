using System;
using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        var result = new StringBuilder();
        int i = 0;

        while (i < input.Length)
        {
            char current = input[i];
            int j = i + 1;
            while (j < input.Length && input[j] == current)
                j++;

            int count = j - i;
            if (count > 1)
                result.Append(count);
            result.Append(current);

            i = j;
        }

        return result.ToString();
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        var result = new StringBuilder();
        int i = 0;

        while (i < input.Length)
        {
            int count = 0;
            while (i < input.Length && char.IsDigit(input[i]))
            {
                count = count * 10 + (input[i] - '0');
                i++;
            }

            if (i < input.Length)
            {
                char c = input[i++];
                if (count == 0)
                    count = 1;
                result.Append(c, count);
            }
        }

        return result.ToString();
    }
}