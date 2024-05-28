namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.CoffeeExample;
// Decorator cho tính năng thêm đường vào cà phê
public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.3; // Giá thêm đường
    }
}