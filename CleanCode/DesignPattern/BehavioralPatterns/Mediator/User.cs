using DesignPattern.BehavioralPatterns.Mediator;
namespace DesignPattern.BehavioralPatterns;
// User class
public class User
{
    private string _name;
    private IChatRoomMediator _chatMediator;

    public User(string name, IChatRoomMediator chatMediator)
    {
        _name = name;
        _chatMediator = chatMediator;
        _chatMediator.AddUser(this);
    }

    public string Name => _name;

    public void Send(string message)
    {
        Console.WriteLine($"{_name} sends: {message}");
        _chatMediator.SendMessage(message, this);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{_name} receives: {message}");
    }

    // Additional method to leave the chat room
    public void LeaveChat()
    {
        Console.WriteLine($"{_name} leaves the chat room.");
        _chatMediator.RemoveUser(this);
    }
}
