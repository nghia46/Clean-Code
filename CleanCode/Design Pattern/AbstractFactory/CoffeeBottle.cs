using CleanCode.AbstractFactory;

public class CoffeeBottle : IBottle
{
    public void Pour()
    {
        Console.WriteLine("Pouring coffee into the bottle.");
    }
}