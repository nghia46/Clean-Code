using CleanCode.DesignPattern.CreationalPatterns.Factory;
using CleanCode.SOLID.Open_Close;

namespace CleanCode.Client.DesignPattern.CreationalPatterns;

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