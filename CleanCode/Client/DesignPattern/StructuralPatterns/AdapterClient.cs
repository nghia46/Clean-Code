using CleanCode.DesignPattern.StructuralPatterns.Adapter;

namespace CleanCode.Client.DesignPattern.StructuralPatterns;
public class AdapterClient
{
    public void Main()
    {
        IOldPaymentSystem oldPaymentSystem = new OldPaymentSystem();
        INewPaymentSystem newPaymentSystem = new PaymentAdapter(oldPaymentSystem);
        newPaymentSystem.MakePayment("123456789", 300);
    }
}