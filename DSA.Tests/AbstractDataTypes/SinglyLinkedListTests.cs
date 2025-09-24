namespace DSA.Tests;

public class SinglyLinkedListTests
{
    private IList<int> list = new SinglyLinkedListIt<int>();

    [Fact]
    public void TestInsertLast()
    {
        Assert.Equal(0, list.Count);
        list.InsertLast(3);
        Assert.Equal(1, list.Count);
    }

    [Fact]
    public void TestInsertFirst()
    {
        Assert.Equal(0, list.Count);
        list.InsertFirst(3);
        Assert.Equal(1, list.Count);
        list.InsertFirst(2);
        Assert.Equal(2, list.Count);
        Assert.Equal(2, list.Head!.Data);
    }

    [Fact]
    public void TestInsertAt()
    {
        Assert.Equal(0, list.Count);
        list.InsertFirst(3);
        list.InsertLast(4);
        list.InsertLast(6);

        int[] expected = { 3, 4, 5, 6 };
        list.InsertAt(5, 2);
        Assert.Equal(4, list.Count);
        Assert.Equal(expected, list.ToArray());
    }

    [Fact]
    public void TestInsertAtZero()
    {
        Assert.Equal(0, list.Count);
        list.InsertFirst(3);
        list.InsertLast(4);
        list.InsertLast(6);

        int[] expected = { 5, 3, 4, 6 };
        list.InsertAt(5, 0);
        Assert.Equal(4, list.Count);
        Assert.Equal(expected, list.ToArray());
    }

    [Fact]
    public void TestInsertAtNegativeIndex()
    {
        var ex = Assert.Throws<IndexOutOfRangeException>(() => list.InsertAt(2, -3));
        Assert.Equal("Invalid index", ex.Message);
    }

    [Fact]
    public void TestInsertAtOutOfRangeIndex()
    {
        var ex1 = Assert.Throws<IndexOutOfRangeException>(() => list.InsertAt(2, 1));
        Assert.Equal("Invalid index", ex1.Message);
    }

    [Fact]
    public void TestSearch()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(2, list.Search(2));
    }

    [Fact]
    public void TestSearchFirst()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(1, list.Search(1));
    }

    [Fact]
    public void TestSearchLast()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(3, list.Search(3));
    }

    [Fact]
    public void TestSearchEmptyList()
    {
        var ex1 = Assert.Throws<InvalidOperationException>(() => list.Search(2));
        Assert.Equal("The list is empty", ex1.Message);
    }

    [Fact]
    public void TestElementNotFound()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);
        var ex1 = Assert.Throws<KeyNotFoundException>(() => list.Search(4));
        Assert.Equal("Element not found", ex1.Message);
    }

    [Fact]
    public void TestRemoveLast()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(3, list.RemoveLast());
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void TestRemoveFirst()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(1, list.RemoveFirst());
        Assert.Equal(2, list.Count);
        Assert.Equal(2, list.Head!.Data);
    }

    [Fact]
    public void TestRemove()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(2, list.Remove(2));
        Assert.Equal(2, list.Count);
        Assert.Equal(1, list.Head!.Data);
    }

    [Fact]
    public void TestRemoveSingleElement()
    {
        list.InsertLast(1);

        Assert.Equal(1, list.Remove(1));
        Assert.Equal(0, list.Count);
    }

    [Fact]
    public void TestRemoveLastElementAltFun()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(3, list.Remove(3));
        Assert.Equal(2, list.Count);
        Assert.Equal(1, list.Head!.Data);
    }

    [Fact]
    public void TestRemoveFirstElementAltFun()
    {
        list.InsertLast(1);
        list.InsertLast(2);
        list.InsertLast(3);

        Assert.Equal(1, list.Remove(1));
        Assert.Equal(2, list.Count);
        Assert.Equal(2, list.Head!.Data);
    }
}
