using PatternLastBeforeHolidays.Factory;
using PatternLastBeforeHolidays.Open_Close;

namespace PatternLastBeforeHolidays.Client;

public class FactoryClient
{
    public void Main()
    {
        var shapeFactory = new ShapeFactory();
        var shape = shapeFactory.GetShape("Circle");
        if (shape is not Circle circle) return;
        circle.Radius = 1f;
        Console.WriteLine(circle.CalculateArea());
    }
}