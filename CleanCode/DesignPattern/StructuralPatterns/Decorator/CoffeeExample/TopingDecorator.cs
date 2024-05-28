namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.CoffeeExample;

public class TopingDecorator : CoffeeDecorator
{
    public TopingDecorator(ICoffee coffee) : base(coffee){}
    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Toping";
    }
    public override double GetCost()
    {
        return base.GetCost() + 2;
    }

}