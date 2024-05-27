namespace CleanCode.SOLID.Open_Close;

public class Circle : IShape
{
    public float Radius { get; set; }

    public float CalculateArea()
    {
        return MathF.Pow(Radius, 2) * MathF.PI;
    }
}