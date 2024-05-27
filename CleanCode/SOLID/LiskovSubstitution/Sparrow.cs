namespace CleanCode.SOLID.LiskovSubstitution;
public class Sparrow : IBird
{
    public void Move()
    {
        Console.WriteLine("Sparrow is flying");
    }
}