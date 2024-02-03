namespace PatternLastBeforeHolidays.ObjectPool;

public class ObjectPool<T> where T : new()
{
    private Stack<T> _objects;
    public ObjectPool(int initialSize)
    {
        _objects = new Stack<T>(initialSize);
        for (int i = 0; i < initialSize; i++)
        {
            _objects.Push(new T());
        }
    }
    public T GetObject()
    {
        if (_objects.Count > 0)
        {
            return _objects.Pop();
        }
        else
        {
            System.Console.WriteLine("Out of pool return a new object!");
            return new T();
        }
    }
    public void ReturnObject(T obj)
    {

        _objects.Push(obj);
    }
    public int GetPoolSize()
    {
        return _objects.Count();
    }
}