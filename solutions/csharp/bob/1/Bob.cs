public static class Bob
{
    public static string Response(string statement)
  {
        statement = statement.Trim();
      if(statement == null || statement.Trim().Length == 0)
     {
         return "Fine. Be that way!";
     }
     if( statement.Any(char.IsLetter) &&statement == statement.ToUpper() && statement.EndsWith("?"))
     {
         return "Calm down, I know what I'm doing!";
     }
     if (statement.Any(char.IsLetter) && statement == statement.ToUpper())
     {
         return "Whoa, chill out!";
     }


     if (statement.EndsWith("?"))
     {
         return "Sure."; 
     }
      
     return "Whatever.";
 }
}