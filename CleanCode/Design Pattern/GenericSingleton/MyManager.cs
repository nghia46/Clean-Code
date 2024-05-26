namespace CleanCode.GenericSingleton;

public class MyManager : Singleton<MyManager>
{
    public static void DoSomething()
    {
        Console.WriteLine("Doing something!");
    }
}