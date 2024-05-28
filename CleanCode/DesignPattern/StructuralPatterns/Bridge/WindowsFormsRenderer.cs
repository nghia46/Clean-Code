namespace CleanCode.DesignPattern.StructuralPatterns.Bridge;
// Implementer cho Windows Forms
public class WindowsFormsRenderer : IRenderer
{
    public void RenderHexagon(float sideLength)
    {
        Console.WriteLine($"WindowsFormsRenderer.RenderHexagon({sideLength})");
    }

    public void RenderTriangle(float sideLength)
    {
        Console.WriteLine($"WindowsFormsRenderer.RenderTriangle({sideLength})");
    }
}