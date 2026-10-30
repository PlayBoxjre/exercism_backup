public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
      public static string SubstringAfter(this string str , string splitor){
            return str[(str.IndexOf(splitor) + splitor.Length)..];
        }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str , string a,string b){
        Console.WriteLine(str[str.IndexOf(a)..str.IndexOf(b)]);
        return str[(str.IndexOf(a) + a.Length) .. (str.IndexOf(b) )];
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str){
        return SubstringAfter(str,":").Trim();
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str){
        return SubstringBetween(str,"[","]");
    }
}