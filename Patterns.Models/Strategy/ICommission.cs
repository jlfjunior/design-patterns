namespace Patterns.Models.Strategy
{
    public interface ICommission
    {
        decimal GetCommission(Order order);
    }
}
