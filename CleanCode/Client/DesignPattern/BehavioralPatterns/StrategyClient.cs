using CleanCode.DesignPattern.BehavioralPatterns.Strategy.Example2;

namespace CleanCode.Client.DesignPattern.BehavioralPatterns;

public class StrategyClient
{
    public void Main()
    {
        #region Example 2
        Sorter sorter = new Sorter();
        int[] array = { 1, 5, 3, 2, 4 };
        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", array));

        // Sắp xếp bằng Bubble Sort
        sorter.SetSortStrategy(new BubbleSortStrategy());
        sorter.Sort(array);
        Console.WriteLine("Sorted array using Bubble Sort:");
        Console.WriteLine(string.Join(", ", array));

        // Reset array
        array = new int[] { 5, 3, 8, 1, 2 };

        // Sắp xếp bằng Quick Sort
        sorter.SetSortStrategy(new QuickSortStrategy());
        sorter.Sort(array);
        Console.WriteLine("Sorted array using Quick Sort:");
        Console.WriteLine(string.Join(", ", array));

        // Reset array
        array = new int[] { 5, 3, 8, 1, 2 };

        // Sắp xếp bằng Merge Sort
        sorter.SetSortStrategy(new MergeSortStrategy());
        sorter.Sort(array);
        Console.WriteLine("Sorted array using Merge Sort:");
        Console.WriteLine(string.Join(", ", array));
        
        #endregion
        #region Example 1
        // Order order = new Order
        // {
        //     Amount = 1000
        // };

        // // Không giảm giá
        // order.SetDiscountStrategy(new NoDiscountStrategy());
        // Console.WriteLine($"Final Price (No Discount): {order.GetDiscountedPrice()}");

        // // Giảm giá theo mùa
        // order.SetDiscountStrategy(new SeasonalDiscountStrategy());
        // Console.WriteLine($"Final Price (Seasonal Discount): {order.GetDiscountedPrice()}");

        // // Giảm giá cho khách hàng thân thiết
        // order.SetDiscountStrategy(new LoyaltyDiscountStrategy());
        // Console.WriteLine($"Final Price (Loyalty Discount): {order.GetDiscountedPrice()}");
        #endregion
    }
}