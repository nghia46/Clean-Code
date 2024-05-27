using CleanCode.AbstractFactory;

public class CoffeeLabel : ILabel
{
    public void Print()
    {
        Console.WriteLine("Printing coffee label.");
    }
}