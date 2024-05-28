namespace CleanCode.DesignPattern.StructuralPatterns.Bridge;
// Interface cho việc vẽ
public interface IRenderer
{
    void RenderHexagon(float sideLength);
    void RenderTriangle(float sideLength);
}