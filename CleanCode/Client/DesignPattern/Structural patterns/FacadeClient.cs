using CleanCode.DesignPattern.StructuralPatterns.Facade;

namespace CleanCode.Client.DesignPattern.Structural_patterns;

public class FacadeClient
{
    public void Main()
    {
        var bookingFacade = new BookingFacade();
        bookingFacade.BookFlightAndNotify("New York", "Los Angeles", "John Doe", "john.doe@example.com", "123-456-7890");
    }
}