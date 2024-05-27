namespace CleanCode.Techniques.DependencyInjection;

public class PetrolEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Petrol engine started.");
    }

    public void Stop()
    {
        Console.WriteLine("Petrol engine stopped.");
    }
}