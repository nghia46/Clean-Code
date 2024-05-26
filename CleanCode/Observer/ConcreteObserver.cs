namespace CleanCode.Observer;

public class ConcreteObserver : IObserver
{
    public string name;
    public ConcreteObserver(string name)
    {
        this.name = name;
    }
    public void Update(string message)
    {
        Console.WriteLine($"{name} received update: {message}");

    }
}