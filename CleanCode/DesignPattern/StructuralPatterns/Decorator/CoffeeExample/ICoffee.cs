// Interface đại diện cho các loại cà phê
namespace CleanCode.DesignPattern.StructuralPatterns.Decorator.CoffeeExample;
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}