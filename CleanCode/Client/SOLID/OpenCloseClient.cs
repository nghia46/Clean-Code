using CleanCode.SOLID.Open_Close;

namespace CleanCode.Client.SOLID;

public class OpenCloseClient
{
    public void Main()
    {
        Square square = new(){
            Side= 10f
        };
        var result = square.CalculateArea();
        Console.WriteLine(result.ToString("0.00"));
    }
}