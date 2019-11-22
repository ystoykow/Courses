namespace Logger.Appenders
{
    using Contracts;
    using Logger.Layouts.Contracts;
    using Loggers;
    using System;

    public class AppenderFactory : IAppenderFactory
    {
        public IAppender Create(string type, ILayout layout)
        {
            string typeAsLower = type.ToLower();
            switch (typeAsLower)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default: 
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
