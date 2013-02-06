using System;
using log4net;

namespace DuckLibrary.Logging
{
    public class Log4NetWriter : ILogWriter
    {
        private ILog log;

        public Log4NetWriter(Type type)
        {
            log = LogManager.GetLogger(type);
        }

        public void WriteMessage(string message)
        {
            log.Debug(message);
        }
    }
}