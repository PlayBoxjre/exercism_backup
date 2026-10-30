
using System;
using System.Text;
public static class RomanNumeralExtension
{    private static readonly (int Value, string Symbol)[] Numerals =
    {
        (1000, "M"),
        (900,  "CM"),
        (500,  "D"),
        (400,  "CD"),
        (100,  "C"),
        (90,   "XC"),
        (50,   "L"),
        (40,   "XL"),
        (10,   "X"),
        (9,    "IX"),
        (5,    "V"),
        (4,    "IV"),
        (1,    "I"),
    };
    public static string ToRoman(this int number)
     {
        if (number is < 1 or > 3999)
            throw new ArgumentOutOfRangeException(
                nameof(number), "Roman numerals are defined for 1–3999.");

        var result = new StringBuilder();
        foreach (var (value, symbol) in Numerals)
        {
            while (number >= value)
            {
                result.Append(symbol);
                number -= value;
            }
        }
        return result.ToString();
    }
}