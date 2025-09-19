namespace DSA.Tests;

public class MinHeapTests
{
    private Comparator<int> comparator = new MinHeapComparator<int>();
    private Heap<int> eHeap;
    private Heap<int> heap;

    public MinHeapTests()
    {
        heap = new Heap<int>(comparator);
        eHeap = new Heap<int>(comparator);

        heap.Insert(40);
        heap.Insert(30);
        heap.Insert(15);
        heap.Insert(10);
        heap.Insert(20);
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

    [Fact]
    public void TestToArray()
    {
        var expected = new int[] { 10, 15, 30, 40, 20 };
        Assert.Equal(expected, heap.ToArray());
    }

    [Fact]
    public void TestInsert()
    {
        eHeap.Insert(3);
        Assert.False(eHeap.IsEmpty());
        Assert.Equal(3, eHeap.Root());
    }

    [Fact]
    public void TestInsertHeapify()
    {
        heap.Insert(5);
        Assert.False(heap.IsEmpty());
        Assert.Equal(5, heap.Root());
    }

    [Fact]
    public void TestSize()
    {
        Assert.Equal(5, heap.Size());
        heap.Insert(45);
        Assert.Equal(6, heap.Size());
    }

    [Fact]
    public void TestEmptyHeapSize()
    {
        Assert.Equal(0, eHeap.Size());
    }

    [Fact]
    public void TestBuildHeap()
    {
        var array = new int[] { 6, 5, 4, 3, 2, 1 };
        var expected = new int[] { 1, 2, 4, 3, 5, 6 };
        heap.BuildHeap(array);
        Assert.Equal(6, heap.Size());
        Assert.Equal(expected, heap.ToArray());
    }

    [Fact]
    public void TestExtractRoot()
    {
        var expected = new int[] { 15, 20, 30, 40 };
        Assert.Equal(10, heap.ExtractRoot());
        Assert.Equal(15, heap.Root());
        Assert.Equal(expected, heap.ToArray());
    }
}