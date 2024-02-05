using PatternLastBeforeHolidays.State;

public class RedLightState : ITrafficLightState
{
    public void Handel(TrafficLight context)
    {
        Console.WriteLine("Red Light: Stop");
        // Chuyển sang trạng thái đèn xanh
        context.SetState(new GreenLightState());
    }

}