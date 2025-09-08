namespace DSA.Tests;

public class LinkedListTests
{
    private LinkedList<int> list = new LinkedList<int>();

    [Fact]
    public void TestAppend()
    {
        list.Append(3);
        Assert.Equal(3, list.Get(0));
    }

    [Fact]
    public void TestAppendMultiple()
    {
        list.Append(3);
        list.Append(4);
        list.Append(-7);
        Assert.Equal(3, list.Get(0));
    }

    [Fact]
    public void TestInsertAtBeginning()
    {
        list.InsertAtBeginning(3);
        list.InsertAtBeginning(4);
        list.Append(7);
        Assert.Equal(4, list.Get(0));
    }

    [Fact]
    public void TestGetElement()
    {
        list.Append(3);
        Assert.Equal(3, list.Get(0));
    }

    [Fact]
    public void TestInsertAt()
    {
        list.Append(7);
        list.Append(3);
        list.Append(4);
        list.Append(-7);
        list.InsertAt(5, 2);
        Assert.Equal(5, list.Get(2));
    }

    [Fact]
    public void TestInsertAtZero()
    {
        list.Append(7);
        list.Append(3);
        list.Append(4);
        list.Append(-7);
        list.InsertAt(5, 0);
        Assert.Equal(5, list.Get(0));
    }

    [Fact]
    public void InsertAtInvalidIndex()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => list.InsertAt(1, 4));
        Assert.Equal("Invalid index", ex.Message);

        var ex2 = Assert.Throws<InvalidOperationException>(() => list.InsertAt(-1, 4));
        Assert.Equal("Invalid index", ex.Message);
    }

    [Fact]
    public void TestGetInEmptyList()
    {
        var ex = Assert.Throws<IndexOutOfRangeException>(() => list.Get(4));
        Assert.Equal("Element not found", ex.Message);
    }

    [Fact]
    public void TestGetInnalidIndex()
    {
        list.Append(1);
        list.Append(2);
        var ex = Assert.Throws<IndexOutOfRangeException>(() => list.Get(4));
        Assert.Equal("Element not found", ex.Message);
    }

    [Fact]
    public void TestCount()
    {
        Assert.Equal(0, list.Count);
        list.Append(3);
        list.Append(2);
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void TestSearch()
    {
        list.Append(3);
        list.Append(4);
        Assert.True(list.Search(3));
        Assert.False(list.Search(5));
    }

    [Fact]
    public void TestRemove()
    {
        list.Append(1);
        list.Append(2);
        list.Append(3);

        Assert.Equal(2, list.Get(1));
        Assert.Equal(3, list.Count);

        list.Remove(1);

        Assert.Equal(3, list.Get(1));
        Assert.Equal(2, list.Count);
    }
}