namespace PatternLastBeforeHolidays.DependencyInjection;

public class OilEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Oil Engine Started.");
    }

    public void Stop()
    {
        Console.WriteLine("Oil Engine Stopped.");
    }
}