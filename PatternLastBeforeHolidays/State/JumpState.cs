namespace PatternLastBeforeHolidays.State;

public class JumpState : IState
{
    public void Enter()
    {
        Console.WriteLine("Enter Jump state");
    }
    public void Exit()
    {
        Console.WriteLine("In Jump state");
    }
    public void Update()
    {
        Console.WriteLine("Exit Jump state");
    }
}