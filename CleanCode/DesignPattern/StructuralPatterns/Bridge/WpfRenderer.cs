namespace CleanCode.DesignPattern.StructuralPatterns.Bridge;
// Implementer cho WPF
public class WpfRenderer : IRenderer
{
    public void RenderHexagon(float sideLength)
    {
        Console.WriteLine($"WpfRenderer.RenderHexagon({sideLength})");
    }

    public void RenderTriangle(float sideLength)
    {
        Console.WriteLine($"WpfRenderer.RenderTriangle({sideLength})");
    }
}