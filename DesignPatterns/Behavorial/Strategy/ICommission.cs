namespace DesignPatterns.Behavorial.Strategy
{
    public interface ICommission
    {
        decimal GetValue(Order order);
    }
}
