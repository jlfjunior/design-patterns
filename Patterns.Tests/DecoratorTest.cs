using Patterns.Models.Decorator;
using Patterns.Models.Decorator.Componet;
using Xunit;

namespace Patterns.Tests
{
    public class DecoratorTest
    {
        [Fact]
        public void ShouldGetMDecoratedMessages()
        {
            var decorator = new BaseDecorator(new Notifier("O Sistema falhou!"));
            var decorator2 = new SlackDecorator(decorator);
            var decorator3 = new FacebookDecorator(decorator2);

            var messageOne = "O Sistema falhou!\n Enviando para: - Email";
            var messageTwo = "O Sistema falhou!\n Enviando para: - Email - Slack";
            var messageThree = "O Sistema falhou!\n Enviando para: - Email - Slack - Facebook";

            Assert.Equal(messageOne, decorator.GetMessage());
            Assert.Equal(messageTwo, decorator2.GetMessage());
            Assert.Equal(messageThree, decorator3.GetMessage());
        }
    }
}
