namespace Patterns.Models.Strategy
{
    public class Employee
    {
        public EmployeeType Type { get; set; }
        public string FullName { get; set; }

        public Employee(EmployeeType type, string fullName)
        {
            Type = type;
            FullName = fullName;
        }
    }

    public enum EmployeeType
    {
        Representative = 1,
        Vendor = 2,
        Manager = 3
    }
}
