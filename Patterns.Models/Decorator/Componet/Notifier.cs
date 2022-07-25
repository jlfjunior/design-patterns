using Patterns.Models.Decorator.Interface;

namespace Patterns.Models.Decorator.Componet
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
