namespace CleanCode.DesignPattern.StructuralPatterns.Facade;

public class NotificationSystem
{
    public void SendEmail(string emailAddress, string message)
    {
        Console.WriteLine($"Sending email to {emailAddress}: {message}");
    }

    public void SendSMS(string phoneNumber, string message)
    {
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
    }
}