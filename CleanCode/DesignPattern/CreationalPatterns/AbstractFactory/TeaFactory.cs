namespace CleanCode.DesignPattern.CreationalPatterns.AbstractFactory;

public class TeaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Tea();
    }

    public IBottle CreateBottle()
    {
        return new TeaBottle();
    }

    public ILabel CreateLabel()
    {
        return new TeaLabel();
    }
}