// Decorator cho tính năng thêm sữa vào cà phê
namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.CoffeeExample;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5; // Giá thêm sữa
    }
}