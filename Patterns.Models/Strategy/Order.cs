namespace Patterns.Models.Strategy
{
    public class Order
    {
        public Employee Employee { get; set; }
        public decimal TotalValue { get; set; }
        public ICommission Commission { get; }

        public Order(Employee employee, decimal totalValue)
        {
            TotalValue = totalValue;

            if (employee.Type == EmployeeType.Representative)
            {
                Commission = new CommissionBasic();
            }

            if (employee.Type == EmployeeType.Vendor)
            {
                Commission = new CommissionMiddle();
            }

            if (employee.Type == EmployeeType.Manager)
            {
                Commission = new CommissionFull();
            }
        }

        public decimal GetCommission()
        {
            return Commission.GetCommission(this);
        }
    }
}
