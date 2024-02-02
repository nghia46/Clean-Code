using Open_Close;
namespace PatternLastBeforeHolidays.Open_Close;
public class OpenCloseClient
{
    public void Main()
    {
        Rectangle rectangle = new()
        {
            Lenght = 2,
            Width = 34
        };
        var result = rectangle.CalculateArea();
        Console.WriteLine(result.ToString("0.00"));
    }
}
