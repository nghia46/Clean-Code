using CleanCode.DesignPattern.BehavioralPatterns.State;

namespace CleanCode.Client.DesignPattern.BehavioralPatterns;
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