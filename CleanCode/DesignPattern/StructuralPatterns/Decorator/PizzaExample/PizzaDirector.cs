namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

public class PizzaDirector
{
    private PizzaBuilder _builder;

    public PizzaDirector(PizzaBuilder builder)
    {
        _builder = builder;
    }

    public IPizza BuildClassicPizza()
    {
        return _builder.AddCheese().AddPepperoni().Build();
    }

    public IPizza BuildVeggiePizza()
    {
        return _builder.AddCheese().AddOlives().Build();
    }

    public IPizza BuildFullyLoadedPizza()
    {
        return _builder.AddCheese().AddCheese().AddPepperoni().AddOlives().Build();
    }
    public IPizza BuildMeatLoversPizza()
    {
        return _builder.AddPepperoni().AddPepperoni().Build();
    }

    public IPizza BuildCheeseLoversPizza()
    {
        return _builder.AddCheese().AddCheese().AddCheese().Build();
    }

    public IPizza BuildSupremePizza()
    {
        return _builder.AddCheese().AddPepperoni().AddOlives().AddCheese().AddPepperoni().Build();
    }
    // Custom Build Methods
    public IPizza BuildCustomPizza(bool addCheese, bool addPepperoni, bool addOlives)
    {
        if (addCheese) _builder.AddCheese();
        if (addPepperoni) _builder.AddPepperoni();
        if (addOlives) _builder.AddOlives();
        return _builder.Build();
    }
}