using PatternLastBeforeHolidays.DependencyInjection;

namespace PatternLastBeforeHolidays.Client;

public class DependencyInjectionClient
{
    public void Main()
    {
        // Creating a petrol engine instance
        IEngine engine = new OilEngine();

        // Injecting the petrol engine into the car
        Car myCar = new(engine);

        // Using the car with the injected engine
        myCar.Start();
        myCar.Stop();
    }
}