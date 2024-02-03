// Lớp Client sử dụng mẫu Prototype để tạo ra các bản sao.
namespace PatternLastBeforeHolidays.Prototype;

public class Client
{
    public IPrototype CreateCopy(IPrototype prototype)
    {
        return prototype.Clone();
    }
}