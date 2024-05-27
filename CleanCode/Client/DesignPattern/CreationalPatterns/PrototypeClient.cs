using CleanCode.DesignPattern.CreationalPatterns.Prototype;

namespace CleanCode.Client.DesignPattern.CreationalPatterns;

public class PrototypeClient
{
    public void Main()
    {
        // Tạo một đối tượng mẫu.
        ConcretePrototype prototype = new ConcretePrototype { Id = 1, Name = "Prototype" };

        CleanCode.DesignPattern.CreationalPatterns.Prototype.Client client = new CleanCode.DesignPattern.CreationalPatterns.Prototype.Client();
        // Sử dụng Client để tạo ra các bản sao từ đối tượng mẫu.
        ConcretePrototype copy1 = (ConcretePrototype)client.CreateCopy(prototype);
        copy1.Id = 2;
        copy1.Name = "Copy 1";
        ConcretePrototype copy2 = (ConcretePrototype)client.CreateCopy(prototype);
        copy2.Id = 3;
        copy2.Name = "Copy 2";
        // Kiểm tra xem các bản sao có giống nhau không.
        Console.WriteLine("Original: " + prototype.Id + ", " + prototype.Name);
        Console.WriteLine("Copy 1: " + copy1.Id + ", " + copy1.Name);
        Console.WriteLine("Copy 2: " + copy2.Id + ", " + copy2.Name);
    }
}