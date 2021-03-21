using Patterns.Models.Strategy;
using Xunit;

namespace Patterns.Tests
{
    public class StrategyTest
    {
        [Fact]
        public void ShouldGenerateCommissionBasic()
        {
            var employee = new Employee(EmployeeType.Representative, "Gabriel Pereira");
            var order = new Order(employee, 1000);

            Assert.Equal(10, order.GetCommission());
        }

        [Fact]
        public void ShouldGenerateCommissionMiddle()
        {
            var employee = new Employee(EmployeeType.Vendor, "Isabel Sophia");
            var order = new Order(employee, 1000);

            Assert.Equal(20, order.GetCommission());
        }

        [Fact]
        public void ShouldGenerateCommissionFull()
        {
            var employee = new Employee(EmployeeType.Manager, "Davi Pereira");
            var order = new Order(employee, 1000);

            Assert.Equal(30, order.GetCommission());
        }

    }
}