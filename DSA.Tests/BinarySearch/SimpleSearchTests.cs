namespace DSA.Tests;

public class SimpleSearchTests
{
    IBinarySearch simpleSearch = new SimpleSearch();

    [Fact]
    public void ShouldReturnPositionWhenValueIsPresent()
    {
        int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int actual = simpleSearch.Search(arr, 3);
        int expected = 2;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldReturnMinus1WhenValueIsAbsent()
    {
        int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int actual = simpleSearch.Search(arr, 11);
        int expected = -1;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldReturnFirstIndexWhenTargetIsFirstElement()
    {
        int[] array = { 5, 10, 15, 20 };
        int index = simpleSearch.Search(array, 5);
        Assert.Equal(0, index);
    }

    [Fact]
    public void ShouldReturnLastIndexWhenTargetIsLastElement()
    {
        int[] array = { 5, 10, 15, 20 };
        int index = simpleSearch.Search(array, 20);
        Assert.Equal(3, index);
    }

    [Fact]
    public void ShouldHandleEmptyArray()
    {
        int[] array = { };
        int index = simpleSearch.Search(array, 1);
        Assert.Equal(-1, index);
    }

    [Fact]
    public void ShouldHandleArrayWithOneElementTargetFound()
    {
        int[] array = { 42 };
        int index = simpleSearch.Search(array, 42);
        Assert.Equal(0, index);
    }

    [Fact]
    public void ShouldHandleArrayWithOneElementTargetNotFound()
    {
        int[] array = { 42 };
        int index = simpleSearch.Search(array, 99);
        Assert.Equal(-1, index);
    }
}