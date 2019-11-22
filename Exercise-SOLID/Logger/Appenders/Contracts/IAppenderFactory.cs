namespace Logger.Appenders.Contracts
{
    using Logger.Layouts.Contracts;

    public interface IAppenderFactory
    {
        IAppender Create(string type, ILayout layout);
    }
}
