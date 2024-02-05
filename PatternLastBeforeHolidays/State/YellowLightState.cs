using PatternLastBeforeHolidays.State;

public class YellowLightState : ITrafficLightState
{
    public void Handel(TrafficLight context)
    {
        Console.WriteLine("Yellow Light: Prepare to stop");
        // Chuyển sang trạng thái đèn đỏ
        context.SetState(new RedLightState());
    }
}