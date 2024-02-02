using Open_Close;
using PatternLastBeforeHolidays.Client;
using PatternLastBeforeHolidays.Factory;
using PatternLastBeforeHolidays.GenericSingleton;
using PatternLastBeforeHolidays.Open_Close;

namespace PatternLastBeforeHolidays
{
    internal abstract class Program
    {
        public static void Main()
        {
            //new GenericFactoryClient().Main();
            //new FactoryClient().Main();
            //new SingletonClient().Main();
            //new OpenCloseClient().Main();
            new DepndencyInjectionClient().Main();
        }
    }
} 