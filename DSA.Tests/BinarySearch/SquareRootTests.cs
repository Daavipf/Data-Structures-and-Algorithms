namespace DSA.Tests;

public class SquareRootTests
{
    [Fact]
    public void ShouldReturnSquareRoot()
    {
        int actual = SquareRoot.Sqrt(400);
        int expected = 20;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldReturnZero()
    {
        int actual = SquareRoot.Sqrt(0);
        int expected = 0;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldReturnOne()
    {
        int actual = SquareRoot.Sqrt(1);
        int expected = 1;

        Assert.Equal(expected, actual);
    }
}