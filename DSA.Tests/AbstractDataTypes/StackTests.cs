namespace DSA.Tests;

public class StackTests
{
    Stack<int> stack = new Stack<int>();

    [Fact]
    public void TestInsertElement()
    {
        stack.Push(1);
        Assert.Equal(1, stack.Peek());
    }

    [Fact]
    public void TestCheckEmptyStack()
    {
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void TestInsertOnFullStack()
    {
        Stack<int> stack2 = new Stack<int>(1);
        stack2.Push(1);

        var ex = Assert.Throws<InvalidOperationException>(() => stack2.Push(2));
        Assert.Equal("A pilha está cheia", ex.Message);
    }

    [Fact]
    public void TestPeekEmptyStack()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => stack.Peek());
        Assert.Equal("A pilha está vazia", ex.Message);
    }

    [Fact]
    public void TestPopEmptyStack()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Equal("A pilha está vazia", ex.Message);
    }

    [Fact]
    public void TestPop()
    {
        stack.Push(3);
        stack.Push(1);
        Assert.Equal(1, stack.Pop());
    }

    [Fact]
    public void TestSize()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Assert.Equal(3, stack.Size());
    }

    [Fact]
    public void TestStringsStack()
    {
        Stack<string> stStack = new Stack<string>();
        stStack.Push("Olá");
        stStack.Push("Mundo");
        Assert.Equal("Mundo", stStack.Peek());
    }
}