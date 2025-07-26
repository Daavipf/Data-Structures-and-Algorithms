namespace DSA.Tests;

public class SortingAlgorithmTests
{

    Sorting implementation = new QuickSort();

    [Fact]
    public void EvenArrayTest()
    {
        int[] arr = [1, 5, 2, 3, 8, 6, 0, 9];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Fact]
    public void OddArrayTest()
    {
        int[] arr = [1, 5, 2, 3, 8, 6, 0, 9, 7];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Fact]
    public void RepeatedNumbersTest()
    {
        int[] arr = [1, 5, 2, 3, 8, 3, 0, 9, 3];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Fact]
    public void EmptyArrayTest()
    {
        int[] arr = [];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Fact]
    public void SameNumberTest()
    {
        int[] arr = [1, 1, 1, 1, 1];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }
}