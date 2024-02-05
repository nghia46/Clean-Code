namespace PatternLastBeforeHolidays.State;

public class WalkState : IState
{
    public void Enter()
    {
        System.Console.WriteLine("Enter Walk state");
    }
    public void Exit()
    {
        System.Console.WriteLine("In Walk state");
    }
    public void Update()
    {
        System.Console.WriteLine("Exit Walk state");
    }
}