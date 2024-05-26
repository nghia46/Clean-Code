using CleanCode.Observer;

namespace CleanCode.Client;

public class ObserverClient {
    public void Main()
    {
        Subject subject = new();
        ConcreteObserver observer1 = new("Observer 1");
        ConcreteObserver observer2 = new("Observer 2");
        
        subject.NotifyObservers += observer1.Update;
        subject.NotifyObservers += observer2.Update;

        subject.NotifyObservers -= observer1.Update;
        subject.DoSomeThing();


    }
}
// Mẫu này khá giống với Event-action 