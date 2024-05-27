using CleanCode.DesignPattern.CreationalPatterns.AbstractFactory;

namespace CleanCode.Client.DesignPattern.CreationalPatterns;

public class AbstractFactoryClient {
    public void Main()
    {
        // Chọn nhà máy cụ thể dựa trên loại thức uống
        IBeverageFactory factory;
        factory = new CoffeeFactory();

        // Sử dụng nhà máy để tạo các đối tượng
        IBeverage beverage = factory.CreateBeverage();
        IBottle bottle = factory.CreateBottle();
        ILabel label = factory.CreateLabel();

        // Sử dụng các đối tượng
        beverage.Drink();
        bottle.Pour();
        label.Print();
    }
}