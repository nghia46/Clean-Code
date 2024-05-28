namespace CleanCode.DesignPattern.StructuralPatterns.Adapter;

public class PaymentAdapter : INewPaymentSystem
{
    private readonly IOldPaymentSystem oldPaymentSystem;

    public PaymentAdapter(IOldPaymentSystem oldPaymentSystem)
    {
        this.oldPaymentSystem = oldPaymentSystem;
    }

    public void MakePayment(string accountNumber, double amount)
    {
        // Chuyển đổi thông tin thanh toán mới sang định dạng của hệ thống cũ
        string paymentDetails = $"AccountNumber = {accountNumber}, Amount = {amount}";
        oldPaymentSystem.ProcessPayment(paymentDetails);
    }
}