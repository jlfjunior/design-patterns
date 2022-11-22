using System;

namespace DesignPatterns.Structure.Adapter
{
    public class Logger : ILogger
    {
        public void LogInformation(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }
}