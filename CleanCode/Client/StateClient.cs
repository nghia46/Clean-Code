using CleanCode.State;

namespace CleanCode.Client;
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