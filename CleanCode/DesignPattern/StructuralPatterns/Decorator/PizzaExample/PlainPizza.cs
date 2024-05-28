namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

public class PlainPizza  : IPizza
{
    private double cost = 10f;
    public double GetCost()
    {
        return (double)cost;
    }

    public string GetDescription()
    {
        return $"Pizza({cost}$)";
    }
}