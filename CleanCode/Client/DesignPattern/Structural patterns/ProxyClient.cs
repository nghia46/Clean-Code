using CleanCode.DesignPattern.StructuralPatterns.Proxy;

namespace CleanCode.Client.DesignPattern.Structural_patterns;

public class ProxyClient
{
    public void Main()
    {
        IDocument document = new DocumentProxy("user","ImportantDocument.pdf");
        document.Display();
    }
}