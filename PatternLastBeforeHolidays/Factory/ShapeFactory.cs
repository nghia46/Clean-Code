using Open_Close;
using PatternLastBeforeHolidays.Open_Close;

namespace PatternLastBeforeHolidays.Factory;

public class ShapeFactory
{
    public IShape? GetShape(string shapeType)
    {
        if (shapeType.Equals(null))
            return null;
        if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            return new Circle();
        else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            return new Rectangle();
        else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            return new Square();
        return null;
    }
}