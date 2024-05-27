namespace CleanCode.DesignPattern.CreationalPatterns.Builder;
public interface IBuilder
{
    void BuildPart1();
    void BuildPart2();
    void BuildPart3();
    public Product GetResult();

}