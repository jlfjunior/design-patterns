namespace Patterns.Models.Strategy
{
    public class Order
    {
        public Employee Employee { get; set; }
        public decimal TotalValue { get; set; }

        public Order(Employee employee, decimal totalValue)
        {
            TotalValue = totalValue;
            Employee = employee;
        }

        public decimal GetCommission() => Employee.Commission.GetValue(this);
    }
}
