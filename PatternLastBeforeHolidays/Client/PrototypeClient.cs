using PatternLastBeforeHolidays.Prototype;

namespace PatternLastBeforeHolidays.Client;

public class PrototypeClient
{
    public void Main()
    {
        // Tạo một đối tượng mẫu.
        ConcretePrototype prototype = new ConcretePrototype { Id = 1, Name = "Prototype" };

        Prototype.Client client = new Prototype.Client();
        // Sử dụng Client để tạo ra các bản sao từ đối tượng mẫu.
        ConcretePrototype copy1 = (ConcretePrototype)client.CreateCopy(prototype);
        ConcretePrototype copy2 = (ConcretePrototype)client.CreateCopy(prototype);
        // Kiểm tra xem các bản sao có giống nhau không.
        Console.WriteLine("Original: " + prototype.Id + ", " + prototype.Name);
        Console.WriteLine("Copy 1: " + copy1.Id + ", " + copy1.Name);
        Console.WriteLine("Copy 2: " + copy2.Id + ", " + copy2.Name);
    }
}