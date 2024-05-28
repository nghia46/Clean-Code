namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

public class PepperoniDecorator : PizzaDecorator
{
    private readonly double cost = 1.5f;
    public PepperoniDecorator(IPizza pizza) : base(pizza)
    {
    }
    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Pepperoni({cost}$)";
    }

    public override double GetCost()
    {
        return base.GetCost() + cost; // Giá thêm pepperoni
    }
}