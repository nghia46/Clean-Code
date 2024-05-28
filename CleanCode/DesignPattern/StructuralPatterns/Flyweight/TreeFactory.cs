namespace CleanCode.DesignPattern.StructuralPatterns.Flyweight;

public class TreeFactory
{
    public Dictionary<string, ITreeType> treeTypes = new Dictionary<string, ITreeType>();

    public ITreeType GetTreeType(string type, string color, string texture)
    {
        string key = $"{type}_{color}_{texture}";

        if (!treeTypes.ContainsKey(key))
        {
            treeTypes[key] = new TreeType(type, color, texture);
            Console.WriteLine($"Creating tree type: {key}");
        }

        return treeTypes[key];
    }
}