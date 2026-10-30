using System.Text;
public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if(subjects.Length == 0){
            return new string[0];
        }
          StringBuilder sb = new();
        for (int i = 0; i < subjects.Length; i++)
        {
            if (i == subjects.Length - 1)
            {
                sb.Append(String.Format($"And all for the want of a {subjects[0]}."));
            }
            else
            {
                sb.Append(String.Format("For want of a {0} the {1} was lost.", subjects[i], subjects[i+1]))
                    .Append('\n');
            }
        }
        return sb.ToString().Split("\n");
    }
}