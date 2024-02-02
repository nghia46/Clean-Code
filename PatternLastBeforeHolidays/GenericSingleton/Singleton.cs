namespace PatternLastBeforeHolidays.GenericSingleton;

public class Singleton<T> where T : class, new()
{
    private static T? instance;

    private static readonly object lockObject = new object(); 

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                }
            }
            return instance;
        }
    }
}