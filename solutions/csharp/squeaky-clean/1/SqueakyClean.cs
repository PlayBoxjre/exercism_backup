using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
   {
        char[] chars  = identifier.ToCharArray(0, identifier.Length);
        StringBuilder sb = new StringBuilder(chars.Length);
        bool isKebabCase = false;
        foreach (char c in chars)
        {
            if (isKebabCase)
            {
                sb.Append(char.ToUpper(c));
                isKebabCase = false;
                continue;
            }
       
            bool isGreekLowerAlphaOmega = c >= '\u03B1' && c <= '\u03C9';
            if (isGreekLowerAlphaOmega)
            {
                continue; // 希腊小写直接跳过
            }
            if (char.IsWhiteSpace(c))
            {
                sb.Append('_');
                continue;
            }

            if (char.IsControl(c))
            {
                sb.Append("CTRL");
                continue;
            }

            if ('-' == c)
            {
                isKebabCase = true;
                continue;
            }
             if (char.IsLetter(c))
            {
                   sb.Append(c);
                continue;
            }
           
        }
        
        return sb.ToString();
    }
}
