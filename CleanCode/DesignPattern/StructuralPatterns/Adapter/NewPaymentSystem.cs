namespace CleanCode.DesignPattern.StructuralPatterns.Adapter;

public class NewPaymentSystem : INewPaymentSystem
{
    public void MakePayment(string accountNumber, double amount)
    {
        Console.WriteLine($"Processing payment with new system: AccountNumber = {accountNumber}, Amount = {amount}");
    }
}