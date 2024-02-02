using PatternLastBeforeHolidays.Open_Close;

namespace PatternLastBeforeHolidays.Client;

public class OpenCloseClient
{
    public void Main()
    {
        Rectangle rectangle = new()
        {
            Length = 2,
            Width = 34
        };
        var result = rectangle.CalculateArea();
        Console.WriteLine(result.ToString("0.00"));
    }
}