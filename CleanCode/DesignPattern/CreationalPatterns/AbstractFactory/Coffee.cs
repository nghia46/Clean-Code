namespace CleanCode.DesignPattern.CreationalPatterns.AbstractFactory;
public class Coffee : IBeverage
{
    public void Drink()
    {
        Console.WriteLine("Drinking coffee.");
    }
}