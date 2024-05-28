namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

public class CheeseDecorator : PizzaDecorator
{
    private readonly double cost = 2.5f;
    public CheeseDecorator(IPizza pizza) : base(pizza)
    {
    }
    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Cheese({cost}$)";
    }

    public override double GetCost()
    {
        return base.GetCost() + cost; // Giá thêm chesse
    }
}