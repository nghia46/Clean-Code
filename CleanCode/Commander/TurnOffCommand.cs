namespace CleanCode.Commander;

public class TurnOffCommand : ICommand
{
    private readonly FanReceiver fan;
    public TurnOffCommand(FanReceiver fan)
    {
        this.fan = fan;
    }
    public void Execute()
    {
        fan.TurnOff();
    }
}