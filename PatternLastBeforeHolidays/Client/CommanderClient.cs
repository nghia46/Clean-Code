using PatternLastBeforeHolidays.Commander;

namespace PatternLastBeforeHolidays.Client;

public class CommanderClient
{
    public void Main()
    {
        FanReceiver fan = new();
        ICommand turnOnCommand = new TurnOnCommand(fan);
        ICommand turnOffCommand = new TurnOffCommand(fan);

        FanRemote remote = new(turnOnCommand,turnOffCommand);
        remote.TurnOnButton();
        remote.TurnOffButton();
    }
}