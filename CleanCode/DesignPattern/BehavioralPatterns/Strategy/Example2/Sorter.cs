// Lớp Sorter sử dụng Strategy
namespace CleanCode.DesignPattern.BehavioralPatterns.Strategy.Example2;

public class Sorter
{
    private ISortStrategy? _sortStrategy;

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Sort(int[] array)
    {
        if (_sortStrategy == null)
        {
            throw new ArgumentNullException("sortStrategy");
        }
        _sortStrategy.Sort(array);
    }
}