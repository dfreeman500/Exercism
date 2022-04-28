using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] subs = logLine.Split(':');
        
        return subs[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] subs = logLine.Split(':');

        string newString = subs[0].Remove(0, 1);
        newString = newString.Remove(newString.Length-1);
        
        return newString.ToLower();
    }

    public static string Reformat(string logLine)
    {
        
        return $"{Message(logLine)} ({LogLevel(logLine)})";
        

        
    }
}
