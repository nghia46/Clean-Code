namespace CleanCode.DesignPattern.CreationalPatterns.AbstractFactory;

public interface IBeverageFactory
{
    IBeverage CreateBeverage();
    IBottle CreateBottle();
    ILabel CreateLabel();
}