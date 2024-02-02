using PatternLastBeforeHolidays.GenericFactory;
using PatternLastBeforeHolidays.Open_Close;

namespace PatternLastBeforeHolidays.Client;

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