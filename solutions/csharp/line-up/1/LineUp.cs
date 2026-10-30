public static class LineUp
{
   public static string Format(string name, int number)
   {
      int a = number % 100;
      string subfix =  (number % 10) switch
       {
           1 => "st",
           2 => "nd",
           3 => "rd",
           _ => "th"
       };
       subfix = (a == 11) || a == 12 || a == 13 ? "th" : subfix;

       return String.Format("{0}, you are the {1}{2} customer we serve today. Thank you!",
           name, number,
           subfix
           );
   }
}
