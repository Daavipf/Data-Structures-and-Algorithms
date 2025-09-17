namespace DSA.Tests;

public class HeapTests
{
    private Comparator<int> comparator = new MaxHeapComparator<int>();
    private Heap<int> eHeap;
    private Heap<int> heap;

    public HeapTests()
    {
        heap = new Heap<int>(comparator);
        eHeap = new Heap<int>(comparator);
    }

    [Fact]
    public void TestIsEmpty()
    {
        Assert.True(eHeap.IsEmpty());
    }

    [Fact]
    public void TestEmptyToArray()
    {
        var expected = new List<int> { };
        Assert.Equal(expected, eHeap.ToArray());
    }
}