namespace DesignPatterns.Structure.Adapter
{
    public class Service
    {
        private readonly ILogger _logger;

        public Service(ILogger logger)
        {
            _logger = logger;            
        }

        public override string ToString()
        {
            _logger.LogInformation("Transação");

            return string.Empty;
        }
    }
}