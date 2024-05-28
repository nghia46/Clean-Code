namespace CleanCode.DesignPattern.StructuralPatterns.Flyweight;

public class TreeType : ITreeType
{
    private string type;
    private string color;
    private string texture;

    public TreeType(string type, string color, string texture)
    {
        this.type = type;
        this.color = color;
        this.texture = texture;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Tree: {type}, Color: {color}, Texture: {texture}, Position: ({x}, {y})");
    }
}