// Director quản lý quá trình xây dựng

namespace CleanCode.DesignPattern.CreationalPatterns.Builder;

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void Construct3Part()
    {
        _builder.BuildPart1();
        _builder.BuildPart2();
        _builder.BuildPart3();
    }
    public void Construct2Part()
    {
        _builder.BuildPart1();
        _builder.BuildPart2();
    }
    public void Construct1Part()
    {
        _builder.BuildPart1();
    }
}