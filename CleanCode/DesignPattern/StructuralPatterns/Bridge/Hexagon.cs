// Abstraction cụ thể: hình sáu cạnh (Hexagon)
using CleanCode.DesignPattern.StructuralPatterns.Bridge;
public class Hexagon : Shape
{
    private float sideLength;

    public Hexagon(float sideLength, IRenderer renderer) : base(renderer)
    {
        this.sideLength = sideLength;
    }
    public override void Draw()
    {
        renderer.RenderHexagon(sideLength); // Giả sử RenderHexagon là phương thức vẽ hình sáu cạnh trong IRenderer
    }
}
