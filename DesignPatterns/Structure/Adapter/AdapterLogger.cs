namespace DesignPatterns.Structure.Adapter
{
    public class AdapterLogger : ILogger
    {
        private readonly ICustomLogger _customLogger;

        public AdapterLogger(ICustomLogger customLogger)
        {
            _customLogger = customLogger;
        }

        public void LogInformation(string message)
        {
            _customLogger.LogInfo(message);
        }
    }
}