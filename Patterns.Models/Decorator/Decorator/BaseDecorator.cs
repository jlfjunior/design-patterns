using Patterns.Models.Decorator.Interface;

namespace Patterns.Models.Decorator
{
    public class BaseDecorator : INotifier
    {
        public INotifier Wrappee { get; private set; }

        public BaseDecorator(INotifier wrappee)
        {
            Wrappee = wrappee;
        }

        public virtual string GetMessage()
        {
            return $"{Wrappee.GetMessage()} - Email";
        }
    }
}
