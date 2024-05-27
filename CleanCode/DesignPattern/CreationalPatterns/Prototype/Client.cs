// Lớp Client sử dụng mẫu Prototype để tạo ra các bản sao.
namespace CleanCode.DesignPattern.CreationalPatterns.Prototype;

public class Client
{
    public IPrototype CreateCopy(IPrototype prototype)
    {
        return prototype.Clone();
    }
}