namespace PatternLastBeforeHolidays.Open_Close;

public class AreaCalculator
{
    public float GetArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}