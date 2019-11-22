namespace Logger.Appenders
{
    using Layouts.Contracts;
    using Loggers;
    using Loggers.Contracts;
    using Loggers.Enums;
    using System;
    using System.IO;

    public class FileAppender :Appender
    {
        private const string Path = @"..\..\..\Log.txt";
        private ILayout layout;
        private ILogFile logFile;
        public FileAppender(ILayout layout,ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }
        
        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;

                File.AppendAllText(Path, content);
                this.logFile.Write(content);
                this.AppendMessages++;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";
        }
    }
}
