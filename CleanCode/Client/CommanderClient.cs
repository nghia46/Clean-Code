using CleanCode.Commander;

namespace CleanCode.Client;

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