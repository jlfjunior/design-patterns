namespace DesignPatterns.Behavorial.Bridge
{
    public class XBox : IConsole
    {
        public bool Enable { get; set; } = false;
        public bool JoystickA { get; set; } = false;

        public bool IsOn() => Enable;

        public bool JoystickIsConnected() => JoystickA;

        public bool Shutdown()
        {
            Enable = false;

            return Enable;
        }

        public bool Startup()
        {
            Enable = true;

            return Enable;
        }
    }
}
