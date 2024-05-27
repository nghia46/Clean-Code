// Builder cụ thể

namespace CleanCode.DesignPattern.CreationalPatterns.Builder;

public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPart1()
    {
        _product.Part1 = "Part1 built";
    }

    public void BuildPart2()
    {
        _product.Part2 = "Part2 built";
    }

    public void BuildPart3()
    {
        _product.Part3 = "Part3 built";
    }

    public Product GetResult()
    {
        return _product;
    }
}