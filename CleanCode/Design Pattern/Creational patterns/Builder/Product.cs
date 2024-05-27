namespace CleanCode.Builder;
// Đối tượng cần xây dựng
public class Product
{
    public string? Part1 { get; set; }
    public string? Part2 { get; set; }
    public string? Part3 { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Part1: {Part1}");
        Console.WriteLine($"Part2: {Part2}");
        Console.WriteLine($"Part3: {Part3}");
    }
}