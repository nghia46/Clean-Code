namespace CleanCode.Client;

public abstract class Program
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
        //new StateClient().Main();
        //new LiskovSubstitutionClient().Main(); 
        //new DependencyInversionClient().Main();
        //new AbstractFactoryClient().Main();
        new BuilderClient().Main();
    }

}
