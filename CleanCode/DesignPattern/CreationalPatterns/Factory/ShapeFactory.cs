using CleanCode.SOLID.Open_Close;

namespace CleanCode.DesignPattern.CreationalPatterns.Factory;

public class ShapeFactory
{
    public IShape? GetShape(string shapeType)
    {
        if (shapeType.Equals(null))
            return null;
        if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            return new Circle();
        if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            return new Rectangle();
        if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            return new Square();
        return null;
    }
}