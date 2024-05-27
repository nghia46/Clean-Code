namespace CleanCode.DesignPattern.CreationalPatterns.AbstractFactory;
public class TeaLabel : ILabel
{
    public void Print()
    {
        Console.WriteLine("Printing tea label.");
    }
}