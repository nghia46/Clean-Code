namespace PatternLastBeforeHolidays.Commander;

public class TurnOnCommand : ICommand
{
    private readonly FanReceiver fan;
    public TurnOnCommand(FanReceiver fan)
    {
        this.fan = fan;
    }
    public void Execute()
    {
        fan.TurnOn();
    }
}