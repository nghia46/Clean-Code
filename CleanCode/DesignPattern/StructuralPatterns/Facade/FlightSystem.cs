namespace CleanCode.DesignPattern.StructuralPatterns.Facade;

public class FlightSystem
{
    public void SearchFlights(string from, string to)
    {
        Console.WriteLine($"Searching for flights from {from} to {to}");
    }

    public void BookFlight(int flightId)
    {
        Console.WriteLine($"Booking flight with ID: {flightId}");
    }
}