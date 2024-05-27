using CleanCode.DesignPattern.BehavioralPatterns.Observer;

namespace ProgramTest.Test;

[TestClass]
public class ObserverTest
{
    [TestMethod]
    public void NotifyObservers_EventTriggered_AllObserversNotified()
    {
        // Arrange
        Subject subject = new Subject();
        ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
        ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

        int notificationsReceivedByObserver1 = 0;
        int notificationsReceivedByObserver2 = 0;

        // Act
        subject.NotifyObservers += (message) =>
        {
            if (message.Contains("Something happened!"))
            {
                notificationsReceivedByObserver1++;
            }
        };

        subject.NotifyObservers += (message) =>
        {
            if (message.Contains("Something happened!"))
            {
                notificationsReceivedByObserver2++;
            }
        };

        subject.DoSomeThing();

        // Assert
        Assert.AreEqual(1, notificationsReceivedByObserver1, "Observer 1 should be notified once.");
        Assert.AreEqual(1, notificationsReceivedByObserver2, "Observer 2 should be notified once.");
    }
}