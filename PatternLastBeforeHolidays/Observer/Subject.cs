namespace PatternLastBeforeHolidays.Observer;

public class Subject {
    public Action<string>? NotifyObservers;

    public void DoSomeThing()
    {
        NotifyObservers?.Invoke("Something happened!");
    }
}