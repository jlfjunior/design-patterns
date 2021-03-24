namespace Patterns.Models.Strategy
{
    public class Employee
    {
        public EmployeeType Type { get; set; }
        public string FullName { get; set; }
        public ICommission Commission { get; private set; }

        public Employee(EmployeeType type, string fullName, ICommission commission)
        {
            Type = type;
            FullName = fullName;
            Commission = commission;
        }
    }

    public enum EmployeeType
    {
        Representative = 1,
        Vendor = 2,
        Manager = 3
    }
}
