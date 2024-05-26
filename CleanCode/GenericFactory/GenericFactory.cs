using CleanCode.OpenClose;

namespace CleanCode.GenericFactory;

public class GenericFactory<T> where T : IShape, new()
{
    public T CreateShape()
    {
        return new T();
    }
}