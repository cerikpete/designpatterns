using System;

namespace DuckLibrary.Logging
{
    public class Logger
    {
        private static ILogWriter logWriter;

        public static ILogWriter For(Type type)
        {
            logWriter = new Log4NetWriter(type);
            return logWriter;
        }
    }
}