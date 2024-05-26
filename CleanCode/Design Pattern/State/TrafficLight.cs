using CleanCode.State;

public class TrafficLight
{
    private ITrafficLightState currentState;

    public TrafficLight(ITrafficLightState initialState)
    {
        currentState = initialState;
    }

    public void SetState(ITrafficLightState newState)
    {
        currentState = newState;
    }

    public void Change()
    {
        currentState.Handel(this);
    }
}