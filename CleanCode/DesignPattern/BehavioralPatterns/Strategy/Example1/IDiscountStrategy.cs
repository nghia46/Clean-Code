// Định nghĩa giao diện Strategy
namespace CleanCode.DesignPattern.BehavioralPatterns.Strategy.Example1;

public interface IDiscountStrategy
{
    double GetDiscountedPrice(double amount);
}