namespace CleanCode.OpenClose;

public class Rectangle : IShape
{
    public float Length { get; set; }
    public float Width { get; set; }
    
    public float CalculateArea()
    {
        return Length * Width;
    }
}