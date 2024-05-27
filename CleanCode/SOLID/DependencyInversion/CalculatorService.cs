namespace CleanCode.SOLID.DependencyInversion;
public class CalculatorService
{
    private readonly ICalculator _calculator;

    public CalculatorService(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public double PerformOperation(double a, double b, string operation)
    {
        switch (operation.ToLower())
        {
            case "add":
                return _calculator.Add(a, b);
            case "subtract":
                return _calculator.Subtract(a, b);
            case "multiply":
                return _calculator.Multiply(a, b);
            case "divide":
                return _calculator.Divide(a, b);
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
}
