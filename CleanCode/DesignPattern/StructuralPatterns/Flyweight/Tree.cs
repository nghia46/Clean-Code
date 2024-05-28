namespace CleanCode.DesignPattern.StructuralPatterns.Flyweight;

public class Tree
{
    private ITreeType treeType;
    private int x;
    private int y;

    public Tree(ITreeType treeType, int x, int y)
    {
        this.treeType = treeType;
        this.x = x;
        this.y = y;
    }

    public void Display()
    {
        treeType.Display(x, y);
    }
}