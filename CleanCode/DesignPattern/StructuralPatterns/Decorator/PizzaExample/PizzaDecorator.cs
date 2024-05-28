namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

public abstract class PizzaDecorator : IPizza
{
    protected IPizza pizza;

    protected PizzaDecorator(IPizza pizza)
    {
        this.pizza = pizza;
    }

    public virtual double GetCost()
    {
        return pizza.GetCost();
    }

    public virtual string GetDescription()
    {
        return pizza.GetDescription();
    }
}