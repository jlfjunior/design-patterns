namespace DesignPatterns.Behavorial.Strategy
{
    public class CommissionBasic : ICommission
    {
        public decimal GetValue(Order order) => order.TotalValue * 0.01M;
    }

    public class CommissionMiddle : ICommission
    {
        public decimal GetValue(Order order) => order.TotalValue * 0.02M;
    }

    public class CommissionFull : ICommission
    {
        public decimal GetValue(Order order) => order.TotalValue * 0.03M;
    }
}
