namespace CleanCode.DesignPattern.StructuralPatterns.Adapter;

public interface INewPaymentSystem
{
    void MakePayment(string accountNumber, double amount);
}