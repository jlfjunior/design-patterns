using Patterns.Models.Decorator.Interface;
namespace Patterns.Models.Decorator
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(INotifier wrappee)
            :base(wrappee)
        {
        }

        public override string GetMessage()
        {
            return $"{Wrappee.GetMessage()} - Slack";
        }
    }
}
