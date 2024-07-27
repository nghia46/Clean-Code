using DesignPattern.BehavioralPatterns;
using DesignPattern.BehavioralPatterns.Mediator;

public class MediatorClient {
    public void Main()
    {
        IChatRoomMediator chatRoom = new ChatRoom();

        var user1 = new User("Alice", chatRoom);
        var user2 = new User("Bob", chatRoom);
        var user3 = new User("Charlie", chatRoom);

        user1.Send("Hello, everyone!");
        user2.Send("Hi, Alice!");
        user3.Send("Hey, folks!");

        // Alice leaves the chat room
        user1.LeaveChat();

        // Bob and Charlie continue the conversation
        user2.Send("Alice has left the chat.");
        user3.Send("Goodbye, Alice!");
    }
}