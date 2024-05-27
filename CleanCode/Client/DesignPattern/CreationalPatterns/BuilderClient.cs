using CleanCode.DesignPattern.CreationalPatterns.Builder;

namespace CleanCode.Client.DesignPattern.CreationalPatterns;

public class BuilderClient {
    public void Main()
    {
        // Tạo một builder
        IBuilder builder = new ConcreteBuilder();
        
        Director director = new Director(builder); 

        director.Construct1Part();

        Product product = builder.GetResult();

        product.ShowInfo();
    }
}