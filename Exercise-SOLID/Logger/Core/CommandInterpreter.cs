namespace Logger.Core
{
    using Appenders;
    using Contracts;
    using Layouts;
    using Logger.Appenders.Contracts;
    using Logger.Layouts.Contracts;
    using Loggers.Enums;
    using System;
    using System.Collections.Generic;

    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private ILayoutFactory layoutFactory;
        private IAppenderFactory appenderFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            string typeAppender = args[0];
            string typeLayout = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;
            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }

            ILayout layout = this.layoutFactory.Create(typeLayout);
            IAppender appender = this.appenderFactory.Create(typeAppender, layout);
            appender.ReportLevel = reportLevel;
            this.appenders.Add(appender);
        }

        public void AddReport(string[] args)
        {
            string reportType = args[0];
            string date = args[1];
            string message = args[2];
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(reportType);
            foreach (var appender in this.appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");
            foreach (var appender in this.appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
