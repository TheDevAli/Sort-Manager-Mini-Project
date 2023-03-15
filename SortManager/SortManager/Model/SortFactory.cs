using SortManager.Model;

namespace Model;

public static class SorterFactory
{
    public static Sorter CreateSorter(string type)
    {
        switch (type.ToLower())
        {
            case "bubblesorter":
                return new BubbleSorter();
            case "mergesorter":
                return new MergeSorter();
            default:
                throw new ArgumentException("Invalid sort type");
        }
    }
}