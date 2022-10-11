using DesignPatterns.Behavorial.Decorator.Interface;

namespace DesignPatterns.Decorator
{
    public class FacebookDecorator : BaseDecorator
    {

        public FacebookDecorator(INotifier wrappee) : base(wrappee)
        {
        }

        public override string GetMessage()
        {
            return $"{Wrappee.GetMessage()} - Facebook";
        }
    }
}
