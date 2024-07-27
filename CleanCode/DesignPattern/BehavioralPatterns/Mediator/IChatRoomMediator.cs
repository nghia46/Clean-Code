namespace DesignPattern.BehavioralPatterns.Mediator;

public interface IChatRoomMediator
{
    void SendMessage(string message, User user);
    void AddUser(User user);
    void RemoveUser(User user);
}
