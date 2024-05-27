using CleanCode.SOLID.Open_Close;

namespace CleanCode.DesignPattern.CreationalPatterns.GenericFactory;

public class GenericFactory<T> where T : IShape, new()
{
    public T CreateShape()
    {
        return new T();
    }
}