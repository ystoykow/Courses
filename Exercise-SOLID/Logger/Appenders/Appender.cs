namespace Logger.Appenders
{
    using Contracts;
    using Logger.Layouts.Contracts;
    using Loggers.Enums;

    public abstract class Appender :IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; }

        public int AppendMessages { get; protected set; } = 0;

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.AppendMessages}";
        }
    }
}
