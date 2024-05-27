using CleanCode.State;

namespace CleanCode.State
{
    public class GreenLightState : ITrafficLightState
    {
        public void Handel(TrafficLight context)
        {
            System.Console.WriteLine("Green light: Go!");
            // Chuyển sang trạng thái đèn vàng
            context.SetState(new YellowLightState());
        }
    }
}