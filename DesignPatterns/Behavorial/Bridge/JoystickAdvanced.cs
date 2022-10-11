namespace DesignPatterns.Behavorial.Bridge
{
    public class JoystickAdvanced : JoystickBasic
    {
        public JoystickAdvanced(IConsole console) : base(console) { }

        public bool ShutdownConsole()
        {
            if (Console.IsOn())
            {
                return !Console.Shutdown();
            }

            return false;
        }
    }
}
