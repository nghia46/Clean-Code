using DesignPattern.BehavioralPatterns;
using DesignPattern.BehavioralPatterns.Mediator;

namespace DesignPattern.BehavioralPatterns;
public class ChatRoom : IChatRoomMediator
{
    private IList<User> _users = new List<User>();
    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void RemoveUser(User user)
    {
        _users.Remove(user);
    }

    public void SendMessage(string message, User user)
    {
        foreach (var u in _users)
        {
            // Message should not be received by the user sending it
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}