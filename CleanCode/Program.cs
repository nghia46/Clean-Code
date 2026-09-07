namespace CleanCode;

public abstract class Program
{
    public static async Task Main()
    {
        #region Clients
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
        //new BuilderClient().Main();
        //new DecoratorClient().Main(); 
        //new AdapterClient().Main(); 
        //new FacadeClient().Main();
        //new ProxyClient().Main();
        //new FlyweightClient().Main();
        //new BridgeClient().Main();
        //new StrategyClient().Main();
        //new MediatorClient().Main();
        new DelegateClient().Main();
        #endregion
    
    }
    
}
