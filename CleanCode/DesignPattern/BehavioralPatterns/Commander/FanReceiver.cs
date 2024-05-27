namespace CleanCode.DesignPattern.BehavioralPatterns.Commander;

public class FanReceiver
{
    public void TurnOn()
    {
        Console.WriteLine("Turn Fan On!");
    }
    public void TurnOff()
    {
        Console.WriteLine("Turn Fans Off!");
    }
}