namespace Patterns.Models.Strategy
{
    public interface ICommission
    {
        decimal GetValue(Order order);
    }
}
