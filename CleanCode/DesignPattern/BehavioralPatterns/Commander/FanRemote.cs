
namespace CleanCode.DesignPattern.BehavioralPatterns.Commander;

public class FanRemote {
    private readonly ICommand turnOnCommand;
    private readonly ICommand turnOffCommand;

    public FanRemote(ICommand turnOnCommand,ICommand turnOffCommand)
    {
        this.turnOffCommand = turnOffCommand;
        this.turnOnCommand = turnOnCommand;
    }
    public void TurnOnButton()
    {
        turnOnCommand.Execute();
    }
    public void TurnOffButton()
    {
        turnOffCommand.Execute();
    }
}