using CleanCode.SOLID.DependencyInversion;

namespace CleanCode.Client.SOLID;
public class DependencyInversionClient {
    public void Main()
    {
        ICalculator calculator = new BasicCalculator();
        CalculatorService calculatorService = new CalculatorService(calculator);
        var result = calculatorService.PerformOperation(10, 5, "add");
        System.Console.WriteLine(result);
    }
}