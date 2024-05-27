namespace CleanCode.DesignPattern.CreationalPatterns.AbstractFactory;
public class TeaBottle : IBottle
{
    public void Pour()
    {
        Console.WriteLine("Pouring tea into the bottle.");
    }
}