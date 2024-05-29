namespace CleanCode.DesignPattern.BehavioralPatterns.Strategy.Example1;

public class SeasonalDiscountStrategy : IDiscountStrategy
{
    public double GetDiscountedPrice(double amount)
    {
        return amount * 0.9; // 10% giảm giá
    }
}