using PatternLastBeforeHolidays.Open_Close;

namespace PatternLastBeforeHolidays.GenericFactory;

public class GenericFactory<T> where T : IShape,new()
{
    public T CreateShape()
    {
        return new T();
    }
}