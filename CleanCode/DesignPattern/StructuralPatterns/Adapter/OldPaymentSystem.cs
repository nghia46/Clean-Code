namespace CleanCode.DesignPattern.StructuralPatterns.Adapter;

public class OldPaymentSystem : IOldPaymentSystem
{
    public void ProcessPayment(string paymentDetails)
    {
        Console.WriteLine($"Processing payment with old system: {paymentDetails}");
    }
}