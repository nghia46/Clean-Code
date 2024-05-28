using CleanCode.DesignPattern.StructuralPatterns.Bridge;

public class Triangle : Shape
{
    public float sideLength;
    public Triangle(float sideLength,IRenderer renderer) : base(renderer)
    {
        this.sideLength = sideLength;
    }

    public override void Draw()
    {
        renderer.RenderTriangle(sideLength);
    }
}