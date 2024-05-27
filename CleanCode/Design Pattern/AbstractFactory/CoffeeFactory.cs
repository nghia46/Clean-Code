using CleanCode.AbstractFactory;

public class CoffeeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Coffee();
    }

    public IBottle CreateBottle()
    {
        return new CoffeeBottle();
    }

    public ILabel CreateLabel()
    {
        return new CoffeeLabel();
    }
}
