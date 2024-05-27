namespace CleanCode.DesignPattern.CreationalPatterns.AbstractFactory;

public class CoffeeLabel : ILabel
{
    public void Print()
    {
        Console.WriteLine("Printing coffee label.");
    }
}