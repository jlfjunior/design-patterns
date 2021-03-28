namespace Patterns.Models.Bridge
{
    public interface IConsole
    {
        public bool Enable { get; set; }
        public bool JoystickA { get; set; }

        bool IsOn();
        bool JoystickIsConnected();
        bool Shutdown();
        bool Startup();
    }
}
