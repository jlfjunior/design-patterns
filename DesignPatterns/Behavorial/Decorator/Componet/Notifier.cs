using DesignPatterns.Behavorial.Decorator.Interface;

namespace DesignPatterns.Decorator.Componet
{
    public class Notifier : INotifier
    {

        public string Message { get; }

        public Notifier(string message)
        {
            Message = message;
        }

        public virtual string GetMessage()
        {
            return Message + "\n Enviando para:";
        }
    }
}
