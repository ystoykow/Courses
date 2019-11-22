namespace Logger.Appenders
{
    using Logger.Layouts.Contracts;
    using System;
    using Loggers.Enums;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(this.Layout.Format, dateTime, reportLevel, message);
                this.AppendMessages++;
            }
        }
    }
}
