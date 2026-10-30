static class LogLine
{
    public static string Message(string logLine) => 
        logLine.Replace("[INFO]:","")
            .Replace("[WARNING]:","")
            .Replace("[ERROR]:","")
            .Trim()
            .Replace("\r\n","")
        ;

    public static string LogLevel(string logLine) => logLine.Substring(logLine.IndexOf("[")+1, logLine.IndexOf("]") -1 ).ToLower();
    public static string Reformat(string logLine) => Message(logLine) + " (" + LogLevel(logLine) + ")";
}
