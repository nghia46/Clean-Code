namespace CleanCode.AbstractFactory;
public class TeaBottle : IBottle
{
    public void Pour()
    {
        Console.WriteLine("Pouring tea into the bottle.");
    }
}