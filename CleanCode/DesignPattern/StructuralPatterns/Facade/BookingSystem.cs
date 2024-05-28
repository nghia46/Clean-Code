namespace CleanCode.DesignPattern.StructuralPatterns.Facade;

public class BookingSystem
{
    public void CreateBooking(int flightId, string customerName)
    {
        Console.WriteLine($"Creating booking for flight ID: {flightId} for customer: {customerName}");
    }

    public void ConfirmBooking(int bookingId)
    {
        Console.WriteLine($"Confirming booking with ID: {bookingId}");
    }
}