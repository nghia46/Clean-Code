namespace CleanCode.DesignPattern.StructuralPatterns.Proxy;

public class RealDocument : IDocument
{
    private string _filename;

    public RealDocument(string filename)
    {
        _filename = filename;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading document from disk: {_filename}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying document: {_filename}");
    }
}