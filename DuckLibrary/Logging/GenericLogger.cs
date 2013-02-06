namespace DuckLibrary.Logging
{
    public class GenericLogger
    {
        private static ILogWriter logWriter;

        public static ILogWriter For<T>()
        {
            logWriter = new Log4NetWriter(typeof(T));
            return logWriter;
        }

        public static ILogWriter For<T>(T objectToLog)
        {
            logWriter = new Log4NetWriter(typeof(T));
            return logWriter;
        }
    }
}