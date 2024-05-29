// Các lớp cụ thể triển khai giao diện Strategy
namespace CleanCode.DesignPattern.BehavioralPatterns.Strategy.Example1;

public class NoDiscountStrategy : IDiscountStrategy
{
    public double GetDiscountedPrice(double amount)
    {
        return amount;
    }
}