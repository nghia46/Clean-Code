namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

public class PizzaBuilder
{
    private IPizza _pizza;

    public PizzaBuilder()
    {
        _pizza = new PlainPizza();
    }

    public PizzaBuilder AddCheese()
    {
        _pizza = new CheeseDecorator(_pizza);
        return this;
    }

    public PizzaBuilder AddPepperoni()
    {
        _pizza = new PepperoniDecorator(_pizza);
        return this;
    }

    public PizzaBuilder AddOlives()
    {
        _pizza = new OlivesDecorator(_pizza);
        return this;
    }

    public IPizza Build()
    {
        return _pizza;
    }
}