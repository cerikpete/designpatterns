namespace DuckLibrary.Logging
{
    public static class LoggingExtensions
    {
        public static void Log<T>(this T objectToLog, string message)
        {
            GenericLogger.For(objectToLog).WriteMessage(message);
        }
    }
}