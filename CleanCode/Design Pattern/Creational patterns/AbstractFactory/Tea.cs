namespace CleanCode.AbstractFactory;

public class Tea : IBeverage
{
    public void Drink()
    {
        Console.WriteLine("Drinking tea.");
    }
}