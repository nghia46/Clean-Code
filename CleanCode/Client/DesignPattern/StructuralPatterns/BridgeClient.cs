using CleanCode.DesignPattern.StructuralPatterns.Bridge;
namespace CleanCode.Client.DesignPattern.StructuralPatterns;

public class BridgeClient {
    public void Main()
    {
        IRenderer winFormRenderer = new WindowsFormsRenderer();
        IRenderer wpfRenderer = new WpfRenderer();

        Shape hexagon = new Hexagon(5, winFormRenderer);
        Shape triangle = new Triangle(5, wpfRenderer);
        triangle.Draw();
        hexagon.Draw();
    }
}