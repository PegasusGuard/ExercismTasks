enum LogLevel
{
    Unknown,
    Trace,
    Debug,
    Info = 4,
    Warning,
    Error,
    Fatal =42

}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        switch (logLine.Substring(1,3))
        {
            case "TRC":
                return (LogLevel)1;
            case "DBG":
                return (LogLevel)2;
            case "INF":
                return (LogLevel)4;
            case "WRN":
                return (LogLevel)5;
            case "ERR":
                return (LogLevel)6;
            case "FTL":
                return (LogLevel)42;
            default:
                return (LogLevel)0;
        }
    }

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
}
