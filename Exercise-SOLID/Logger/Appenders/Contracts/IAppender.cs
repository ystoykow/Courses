namespace Logger.Appenders.Contracts
{
    using Logger.Layouts.Contracts;
    using Loggers.Enums;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }
        int AppendMessages { get;}

        ILayout Layout { get; }

        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
