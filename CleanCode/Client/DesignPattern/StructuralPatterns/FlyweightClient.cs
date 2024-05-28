// Tạo ra 1 triệu cây nhưng chỉ tạo ra 1 loại cây duy nhất
// Giúp thu nhỏ bộ nhớ sử dụng cho các đối tượng TreeType

using CleanCode.DesignPattern.StructuralPatterns.Flyweight;

namespace CleanCode.Client.DesignPattern.StructuralPatterns;

public class FlyweightClient {
    public void Main()
    {
        List<Tree> forest = new List<Tree>();
        TreeFactory treeFactory = new TreeFactory();

        // Tạo 1000 cây
        for (int i = 0; i < 1000000; i++)
        {
            ITreeType treeType = treeFactory.GetTreeType("Oak", "Green", "Rough");
            forest.Add(new Tree(treeType, i, i));
        }

        foreach (var tree in forest)
        {
            tree.Display();
        }

        // Kiểm tra số lượng các đối tượng TreeType được tạo ra
        Console.WriteLine($"Number of tree types created: {treeFactory.treeTypes.Count}");
    }
}