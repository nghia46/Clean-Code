using CleanCode.AbstractFactory;

public interface IBeverageFactory
{
    IBeverage CreateBeverage();
    IBottle CreateBottle();
    ILabel CreateLabel();
}
