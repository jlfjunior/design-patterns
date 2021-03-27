using Patterns.Models.Factory;
using Xunit;

namespace Patterns.Tests
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
