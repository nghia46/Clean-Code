// Lớp cụ thể thực hiện giao diện IPrototype.
namespace CleanCode.DesignPattern.CreationalPatterns.Prototype;

public class ConcretePrototype : IPrototype
{
    public int Id { get; set; }
    public string? Name { get; set; }

    // Phương thức Clone tạo ra một bản sao của đối tượng.
    public IPrototype Clone()
    {
        return new ConcretePrototype { Id = this.Id, Name = this.Name };
    }
}