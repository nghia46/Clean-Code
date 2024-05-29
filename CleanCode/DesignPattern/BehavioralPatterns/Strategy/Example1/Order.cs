// Lớp Order sử dụng Strategy
namespace CleanCode.DesignPattern.BehavioralPatterns.Strategy.Example1;

public class Order
{
    private IDiscountStrategy? _discountStrategy;
    public double Amount { get; set; }

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double GetDiscountedPrice()
    {
        if (_discountStrategy == null)  return Amount;
        return _discountStrategy.GetDiscountedPrice(Amount);
    }
}