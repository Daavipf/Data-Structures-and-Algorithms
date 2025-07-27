namespace DSA.Tests;

public class SortingAlgorithmTests
{
    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void EvenArrayTest(Sorting implementation)
    {
        int[] arr = [1, 5, 2, 3, 8, 6, 0, 9];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void OddArrayTest(Sorting implementation)
    {
        int[] arr = [1, 5, 2, 3, 8, 6, 0, 9, 7];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }


    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void RepeatedNumbersTest(Sorting implementation)
    {
        int[] arr = [1, 5, 2, 3, 8, 3, 0, 9, 3];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void EmptyArrayTest(Sorting implementation)
    {
        int[] arr = [];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void SingleElementTest(Sorting implementation)
    {
        int[] arr = [42];
        implementation.Sort(arr);

        Assert.Equal([42], arr);
    }

    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void SameNumberTest(Sorting implementation)
    {
        int[] arr = [1, 1, 1, 1, 1];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void AlreadySortedTest(Sorting implementation)
    {
        int[] arr = [0, 1, 2, 3, 4, 5, 6, 7];
        implementation.Sort(arr);

        Assert.Equal([0, 1, 2, 3, 4, 5, 6, 7], arr);
    }

    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void ReverseOrderTest(Sorting implementation)
    {
        int[] arr = [9, 8, 7, 6, 5, 4, 3, 2, 1];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }

    [Theory]
    [MemberData(nameof(SortingImplementations.All), MemberType = typeof(SortingImplementations))]
    public void AlternatingRepeatedNumbersTest(Sorting implementation)
    {
        int[] arr = [5, 1, 5, 1, 5, 1];
        implementation.Sort(arr);

        Assert.True(Util.IsSorted(arr));
    }


}