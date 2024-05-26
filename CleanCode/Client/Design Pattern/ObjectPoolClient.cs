using CleanCode.ObjectPool;
using CleanCode.OpenClose;

namespace CleanCode.Client;

public class ObjectPoolClient
{
    public void Main()
    {
        // Khởi tạo ObjectPool với 3 đối tượng ban đầu
        var circlePool = new ObjectPool<Circle>(3);
        Console.WriteLine($"Pool object remain: {circlePool.GetPoolSize()}");

        // Lấy và trả đối tượng từ pool

        //Lấy đối tượng từ pool
        var obj1 = circlePool.GetObject();
        Console.WriteLine($"Using: {obj1}, Pool object remain: {circlePool.GetPoolSize()}");
        circlePool.GetObject(); 
        circlePool.GetObject(); 
        circlePool.GetObject(); 
        circlePool.GetObject(); // Nếu lấy lượng object khi không còn object trong pool thì sẽ tạo ra 1 object mới để dùng, 
        circlePool.GetObject(); //object mới này sẽ không trả về pool sau này, để bảo toàn dung lượng của pool/
        circlePool.GetObject(); 
        circlePool.GetObject(); 
        circlePool.GetObject();
        //Lấy đối tượng từ pool
        var obj2 = circlePool.GetObject();
        Console.WriteLine($"Using: {obj2}, Pool object remain: {circlePool.GetPoolSize()}");


        circlePool.ReturnObject(obj1);
        Console.WriteLine("Object returned to the pool." + "Pool object remain:" + circlePool.GetPoolSize());
        circlePool.ReturnObject(obj2);
        Console.WriteLine("Object returned to the pool." + "Pool object remain:" + circlePool.GetPoolSize());
        var obj3 = circlePool.GetObject();
        Console.WriteLine($"Using: {obj3}, Pool object remain : {circlePool.GetPoolSize()}");

    }
}