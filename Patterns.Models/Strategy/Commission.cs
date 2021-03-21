namespace Patterns.Models.Strategy
{
    public class CommissionBasic : ICommission
    {
        public decimal GetCommission(Order order)
        {
            return order.TotalValue * 0.01M;
        }
    }

    public class CommissionMiddle : ICommission
    {
        public decimal GetCommission(Order order)
        {
            return order.TotalValue * 0.02M;
        }
    }

    public class CommissionFull : ICommission
    {
        public decimal GetCommission(Order order)
        {
            return order.TotalValue * 0.03M;
        }
    }
}
