using CleanCode.DesignPattern.StructuralPatterns.Decorator.PizzaExample;

namespace CleanCode.Client.DesignPattern.StructuralPatterns;

public class DecoratorClient {
    public void Main()
    {
        #region PizzaBuilderExamle2
        PizzaBuilder pizzaBuilder = new PizzaBuilder();
        PizzaDirector director = new PizzaDirector(pizzaBuilder);
        IPizza pizza = director.BuildCheeseLoversPizza();
        Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: {pizza.GetCost()}$");
        #endregion
        # region PizzaBuilderExample1
        // IPizza pizza = new PizzaBuilder()
        //     .AddCheese()
        //     .AddCheese()
        //     .AddPepperoni()
        //     .AddOlives()
        //     .AddPepperoni()
        //     .AddCheese()
        //     .AddOlives()
        //     .Build();
        // Console.WriteLine($"Description: {pizza.GetDescription()}, Cost: {pizza.GetCost()}$");
        # endregion
        # region PizzaExample
        //  // Create a plain pizza
        // IPizza plainPizza = new PlainPizza();
        // Console.WriteLine($"Description: {plainPizza.GetDescription()}, Cost: {plainPizza.GetCost()}$");

        // // Add cheese to the plain pizza
        // IPizza cheesePizza = new CheeseDecorator(plainPizza);
        // Console.WriteLine($"Description: {cheesePizza.GetDescription()}, Cost: {cheesePizza.GetCost()}$");

        // // Add pepperoni to the cheese pizza
        // IPizza pepperoniCheesePizza = new PepperoniDecorator(cheesePizza);
        // Console.WriteLine($"Description: {pepperoniCheesePizza.GetDescription()}, Cost: {pepperoniCheesePizza.GetCost()}$");

        // // Add olives to the pepperoni and cheese pizza
        // IPizza olivesPepperoniCheesePizza = new OlivesDecorator(pepperoniCheesePizza);
        // Console.WriteLine($"Description: {olivesPepperoniCheesePizza.GetDescription()}, Cost: {olivesPepperoniCheesePizza.GetCost()}$");

        // // Add another layer of cheese to the pizza
        // IPizza doubleCheesePizza = new CheeseDecorator(olivesPepperoniCheesePizza);
        // Console.WriteLine($"Description: {doubleCheesePizza.GetDescription()}, Cost: {doubleCheesePizza.GetCost()}$");
        
        // // Add another layer of cheese to the pizza
        // IPizza tripleCheesePizza = new CheeseDecorator(doubleCheesePizza);
        // Console.WriteLine($"Description: {tripleCheesePizza.GetDescription()}, Cost: {tripleCheesePizza.GetCost()}$");
        # endregion
        # region Coffee Example
        // // Tạo một cà phê đen cơ bản
        // ICoffee blackCoffee = new BlackCoffee();
        // Console.WriteLine($"Description: {blackCoffee.GetDescription()}, Cost: {blackCoffee.GetCost()}");

        // // Thêm sữa vào cà phê
        // ICoffee milkCoffee = new MilkDecorator(blackCoffee);
        // Console.WriteLine($"Description: {milkCoffee.GetDescription()}, Cost: {milkCoffee.GetCost()}");

        // // Thêm đường vào cà phê có sữa
        // ICoffee milkSugarCoffee = new SugarDecorator(milkCoffee);
        // Console.WriteLine($"Description: {milkSugarCoffee.GetDescription()}, Cost: {milkSugarCoffee.GetCost()}");

        // // Thêm toping vào cà phê có sữa và đường
        // ICoffee milkSugarTopingCoffee = new TopingDecorator(milkSugarCoffee);
        // Console.WriteLine($"Description: {milkSugarTopingCoffee.GetDescription()}, Cost: {milkSugarTopingCoffee.GetCost()}");

        // // Thêm toping vào cà phê có sữa, toping và đường
        // ICoffee milkSugarDoubleTopingCoffee = new TopingDecorator(milkSugarTopingCoffee);
        // Console.WriteLine($"Description: {milkSugarDoubleTopingCoffee.GetDescription()}, Cost: {milkSugarDoubleTopingCoffee.GetCost()}");
        # endregion
    }
}
