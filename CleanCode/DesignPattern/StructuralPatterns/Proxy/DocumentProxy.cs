namespace CleanCode.DesignPattern.StructuralPatterns.Proxy;

public class DocumentProxy : IDocument
{
    private RealDocument? _realDocument;
    private string _filename;
    private string _role;

    public DocumentProxy(string role,string filename)
    {
        _filename = filename;
        _role = role;
    }

    public void Display()
    {
        // Kiểm tra quyền truy cập trước khi cho phép hiển thị tài liệu
        if (CheckAccess())
        {
            if (_realDocument == null)
            {
                _realDocument = new RealDocument(_filename);
            }
            _realDocument.Display();
        }
        else
        {
            Console.WriteLine("Access Denied: You do not have permission to view this document.");
        }
    }

    private bool CheckAccess()
    {
        // Giả sử kiểm tra quyền truy cập dựa trên logic nào đó
        // Ví dụ: chỉ cho phép hiển thị tài liệu nếu người dùng là "admin"
        string userRole = _role;
        return userRole == "admin";
    }

}