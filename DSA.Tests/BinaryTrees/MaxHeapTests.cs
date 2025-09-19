namespace DSA.Tests;

public class MaxHeapTests
{
    private Comparator<int> comparator = new MaxHeapComparator<int>();
    private Heap<int> eHeap;
    private Heap<int> heap;

    public MaxHeapTests()
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
        var expected = new int[] { 40, 30, 15, 10, 20 };
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
        heap.Insert(45);
        Assert.False(heap.IsEmpty());
        Assert.Equal(45, heap.Root());
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
        var array = new int[] { 1, 2, 3, 4, 5, 6 };
        var expected = new int[] { 6, 5, 3, 4, 2, 1 };
        heap.BuildHeap(array);
        Assert.Equal(6, heap.Size());
        Assert.Equal(expected, heap.ToArray());
    }

    [Fact]
    public void TestExtractRoot()
    {
        var expected = new int[] { 30, 20, 15, 10 };
        Assert.Equal(40, heap.ExtractRoot());
        Assert.Equal(30, heap.Root());
        Assert.Equal(expected, heap.ToArray());
    }

    [Fact]
    public void TestHeapsort()
    {
        var array = new int[] { 6, 1, 3, 4, 2, 5 };
        var expected = new int[] { 1, 2, 3, 4, 5, 6 };
        heap.HeapSort(array);
        Assert.Equal(6, heap.Size());
        Assert.Equal(expected, heap.ToArray());
    }
}