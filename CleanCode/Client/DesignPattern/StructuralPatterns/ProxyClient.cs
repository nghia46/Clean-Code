using CleanCode.DesignPattern.StructuralPatterns.Proxy;

namespace CleanCode.Client.DesignPattern.StructuralPatterns;

public class ProxyClient
{
    public void Main()
    {
        IDocument document = new DocumentProxy("user","ImportantDocument.pdf");
        document.Display();
    }
}