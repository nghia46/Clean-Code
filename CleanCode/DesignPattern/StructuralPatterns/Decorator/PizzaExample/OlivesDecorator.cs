namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

public class OlivesDecorator : PizzaDecorator
{
    private readonly double cost= .5f;
    public OlivesDecorator(IPizza pizza) : base(pizza) { }

    public override string GetDescription()
    {
        return pizza.GetDescription() + $", Olives({cost}$)";
    }

    public override double GetCost()
    {
        return pizza.GetCost() + 0.50; // Cost of adding olives
    }
}