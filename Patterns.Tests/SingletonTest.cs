using Patterns.Models.Singleton;
using Xunit;

namespace Patterns.Tests
{
    public class SingletonTest
    {
        [Fact]
        public void ShouldGetInstance()
        {
            var instance = Singleton.GetInstance();
            var newInstance = Singleton.GetInstance();

            Assert.Equal(instance.ToString(), newInstance.ToString());
        }
    }
}