using DesignPatterns.Creatinal.Factory;
using Xunit;

namespace DesignPatterns.Tests
{
    public class FactoryTest
    {
        [Fact]
        public void ShouldGetDriver()
        {
            var person = PersonFactory.CreatePerson("Joao", cnh: 123);

            Assert.Equal(typeof(Driver), person.GetType());
        }

        [Fact]
        public void ShouldGetVender()
        {
            var person = PersonFactory.CreatePerson("Joao", license: 123);

            Assert.Equal(typeof(Pilot), person.GetType());
        }
    }
}
