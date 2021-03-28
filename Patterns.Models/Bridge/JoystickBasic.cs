namespace Patterns.Models.Bridge
{
    public class JoystickBasic
    {
        public IConsole Console { get; set; }

        public JoystickBasic(IConsole console)
        {
            Console = console;
        }


        public bool ConectOnConsole()
        {
           if (!Console.JoystickIsConnected())
           {
                Console.JoystickA = true;
           }

            return Console.JoystickIsConnected();
        }
    }
}
