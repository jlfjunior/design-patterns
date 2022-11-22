using System;

namespace DesignPatterns.Structure.Adapter
{
    public class CustomLogger : ICustomLogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"CUSTOM LOG: {message}");
        }
    }
}