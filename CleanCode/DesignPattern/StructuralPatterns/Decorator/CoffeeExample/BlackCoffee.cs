// Lớp cơ bản đại diện cho cà phê đen
namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.CoffeeExample;

public class BlackCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Black Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}