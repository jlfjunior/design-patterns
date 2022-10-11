using DesignPatterns.Creatinal.Singleton;
using Xunit;

namespace DesignPatterns.Tests
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