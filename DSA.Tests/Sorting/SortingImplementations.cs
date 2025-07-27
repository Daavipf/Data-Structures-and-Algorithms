namespace DSA;

public static class SortingImplementations
{
    public static IEnumerable<object[]> All =>
        new List<object[]>
        {
            new object[] { new BubbleSort() },
            new object[] { new QuickSort() },
            new object[] { new RadixSort() },
            new object[] { new InsertionSort() },
            new object[] { new SelectionSort() },
            new object[] { new CocktailSort() },
            new object[] { new CountingSort() },
            new object[] { new MergeSort() },
            new object[] { new MergeSortInPlace() },
        };
}
