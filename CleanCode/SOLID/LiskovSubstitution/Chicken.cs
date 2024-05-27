namespace CleanCode.SOLID.LiskovSubstitution;

public class Chicken : IBird
{
    public void Move()
    {
        Console.WriteLine("Chicken is walking around");
    }
}