using PatternLastBeforeHolidays.Open_Close;

namespace Open_Close;
public class Rectangle : IShape
{
    public float Lenght { get; set; }
    public float Width { get; set; }
    public float CalculateArea()
    {
        return Lenght * Width;
    }
}