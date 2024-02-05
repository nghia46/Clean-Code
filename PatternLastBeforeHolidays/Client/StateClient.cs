using PatternLastBeforeHolidays.State;

namespace PatternLastBeforeHolidays.Client;
public class StateClient
{
    public void Main()
    {
        TrafficLight trafficLight = new TrafficLight(new GreenLightState());

        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
        trafficLight.Change();
    }
}