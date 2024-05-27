namespace CleanCode.DesignPattern.CreationalPatterns.GenericSingleton;

public class Singleton<T> where T : class, new()
{
    private static T? instance;

    private static readonly object lockObject = new();

    public static T Instance
    {
        get
        {
            if (instance == null)
                lock (lockObject)
                {
                    instance ??= new T();
                }

            return instance;
        }
    }
}