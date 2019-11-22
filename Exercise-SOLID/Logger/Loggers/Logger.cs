namespace Logger.Loggers
{
    using Enums;
    using Contracts;
    using Appenders.Contracts;

    public class Logger : ILogger
    {
        private IAppender consoleAppender;
        private IAppender fileAppender;

        public Logger(IAppender consoleAppender)
        {
            this.consoleAppender = consoleAppender;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
            : this(consoleAppender)
        {
            this.fileAppender = fileAppender;
        }

        public void Error(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.ERROR, message);
        }

        public void Info(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.INFO, message);
        }

        public void Warning(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.WARNING, message);
        }

        public void Critical(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.CRITICAL, message);
        }

        public void Fatal(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.FATAL, message);
        }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            this.consoleAppender?.Append(dateTime, reportLevel, message);
            this.fileAppender?.Append(dateTime, reportLevel, message);
        }
    }
}
