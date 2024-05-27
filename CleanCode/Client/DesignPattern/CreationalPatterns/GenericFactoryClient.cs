using CleanCode.DesignPattern.CreationalPatterns.GenericFactory;
using CleanCode.SOLID.Open_Close;

namespace CleanCode.Client.DesignPattern.CreationalPatterns;

public class GenericFactoryClient
{
    public void Main()
    {
        var shapeFactoryA = new GenericFactory<Circle>();
        var shapeA = shapeFactoryA.CreateShape();
        shapeA.Radius = 1f;
        Console.WriteLine(shapeA.CalculateArea());
    }
}