namespace CleanCode.DesignPattern.StructuralPatterns.Facade;

public class BookingFacade
{
    private FlightSystem _flightSystem;
    private BookingSystem _bookingSystem;
    private NotificationSystem _notificationSystem;

    public BookingFacade()
    {
        _flightSystem = new FlightSystem();
        _bookingSystem = new BookingSystem();
        _notificationSystem = new NotificationSystem();
    }

    public void BookFlightAndNotify(string from, string to, string customerName, string email, string phone)
    {
        // Tìm kiếm chuyến bay
        _flightSystem.SearchFlights(from, to);

        // Đặt chuyến bay
        _flightSystem.BookFlight(1);

        // Tạo và xác nhận đặt chỗ
        _bookingSystem.CreateBooking(1, customerName);
        _bookingSystem.ConfirmBooking(101);

        // Gửi thông báo qua email và SMS
        _notificationSystem.SendEmail(email, "Your flight has been booked.");
        _notificationSystem.SendSMS(phone, "Your flight has been booked.");
    }
}