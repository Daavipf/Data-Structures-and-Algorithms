namespace DSA.Tests;

public class BSTTests
{
    private BinarySearchTree<int> bt = new BinarySearchTree<int>();
    public BSTTests()
    {
        bt.Insert(10);
        bt.Insert(5);
        bt.Insert(7);
        bt.Insert(14);
        bt.Insert(12);
        bt.Insert(3);
    }

    [Fact]
    public void TestInsert()
    {
        bt.Insert(1);
        Assert.Equal(1, bt.Search(1));

        if (bt.Root is null)
        {
            Assert.Fail("bt.Root is null");
        }

        Assert.Equal(10, bt.Root.Data);
    }

    [Fact]
    public void TestSearch()
    {
        Assert.Equal(3, bt.Search(3));
    }

    [Fact]
    public void TestSearchInvalid()
    {
        var ex = Assert.Throws<Exception>(() => bt.Search(1));
        Assert.Equal("Element not found", ex.Message);
    }

    [Fact]
    public void TestRemove()
    {
        Assert.Equal(3, bt.Search(3));
        bt.Remove(3);

        var ex = Assert.Throws<Exception>(() => bt.Search(3));
        Assert.Equal("Element not found", ex.Message);
    }

    [Fact]
    public void TestRemoveRoot()
    {
        Assert.Equal(10, bt.Search(10));
        bt.Remove(10);

        var ex = Assert.Throws<Exception>(() => bt.Search(10));
        Assert.Equal("Element not found", ex.Message);

        if (bt.Root is null)
        {
            Assert.Fail("bt.Root is null");
        }

        Assert.Equal(12, bt.Root.Data);
    }

    [Fact]
    public void TestSuccessor()
    {
        Assert.Equal(12, bt.Successor(bt.Root));
    }

    [Fact]
    public void TestInsertAndSuccessor()
    {
        bt.Insert(11);
        Assert.Equal(11, bt.Successor(bt.Root));
    }

    [Fact]
    public void TestPredecessor()
    {
        Assert.Equal(7, bt.Predecessor(bt.Root));
    }

    [Fact]
    public void TestInOrderTraversal()
    {
        var expected = new List<int> { 3, 5, 7, 10, 12, 14 };
        var actual = bt.InOrder();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestPreOrderTraversal()
    {
        var expected = new List<int> { 10, 5, 3, 7, 14, 12 };
        var actual = bt.PreOrder();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestPostOrderTraversal()
    {
        var expected = new List<int> { 3, 7, 5, 12, 14, 10 };
        var actual = bt.PostOrder();

        Assert.Equal(expected, actual);
    }
}
