namespace PatternLastBeforeHolidays.Open_Close;

public class Square : IShape
{
    public float Side { get; set; }
    public float CalculateArea()
    {
        return MathF.Pow(Side, 2);
    }
}