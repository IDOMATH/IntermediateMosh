namespace Extensibility
{
    public interface ILogger
    {
        void LogErrors(string message);
        void LogInfo(string message);
    }
}
