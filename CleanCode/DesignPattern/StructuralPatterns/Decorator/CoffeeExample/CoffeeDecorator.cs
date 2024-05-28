// Decorator abstract class, chứa một tham chiếu đến ICoffee
namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.CoffeeExample;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return coffee.GetCost();
    }
}