using System.Net.Http.Headers;
using PatternLastBeforeHolidays.Client;

namespace PatternLastBeforeHolidays;

internal abstract class Program
{
    public static void Main()
    {
        //new GenericFactoryClient().Main();
        //new FactoryClient().Main();
        //new SingletonClient().Main();
        //new OpenCloseClient().Main();
        //new DependencyInjectionClient().Main();
        //new ObjectPoolClient().Main();
        //new CommanderClient().Main();
        //new PrototypeClient().Main();
        //new ObserverClient().Main();
        new StateClient().Main();
    }

}