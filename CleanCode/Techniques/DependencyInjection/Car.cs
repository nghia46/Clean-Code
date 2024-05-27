namespace CleanCode.Techniques.DependencyInjection;

public class Car
{
    private readonly IEngine _engine;

    // Constructor injection
    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        Console.WriteLine("Car is starting.");
        _engine.Start();
    }

    public void Stop()
    {
        Console.WriteLine("Car is stopping.");
        _engine.Stop();
    }
}