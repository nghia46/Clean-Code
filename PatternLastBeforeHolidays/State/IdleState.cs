namespace PatternLastBeforeHolidays.State
{
    public class IdleState : IState
    {
        public void Enter()
        {
            System.Console.WriteLine("Enter Idle state");
        }
        public void Exit()
        {
            System.Console.WriteLine("In Idle state");
        }
        public void Update()
        {
            System.Console.WriteLine("Exit Idle state");

        }
    }
}