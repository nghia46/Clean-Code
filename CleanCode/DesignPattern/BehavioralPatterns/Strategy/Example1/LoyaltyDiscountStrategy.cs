namespace CleanCode.DesignPattern.BehavioralPatterns.Strategy.Example1;

public class LoyaltyDiscountStrategy : IDiscountStrategy
{
    public double GetDiscountedPrice(double amount)
    {
        return amount * 0.8; // 20% giảm giá
    }
}