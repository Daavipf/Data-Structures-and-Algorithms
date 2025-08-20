namespace DSA.Tests;

public class QueueTests
{
    Queue<int> queue = new Queue<int>();

    [Fact]
    public void TestEnqueue()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        Assert.Equal(1, queue.Peek());
    }

    [Fact]
    public void TestEmptyQueue()
    {
        Assert.True(queue.IsEmpty());
    }

    [Fact]
    public void TestInsertOnFullQueue()
    {
        Queue<int> queue2 = new Queue<int>(2);
        queue2.Enqueue(1);
        queue2.Enqueue(2);

        var ex = Assert.Throws<InvalidOperationException>(() => queue2.Enqueue(3));
        Assert.Equal("A fila está cheia", ex.Message);
    }

    [Fact]
    public void TestDequeue()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Peek());
    }

    [Fact]
    public void TestDequeueOnEmptyQueue()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        Assert.Equal("A fila está vazia", ex.Message);
    }

    [Fact]
    public void TestSize()
    {
        Assert.Equal(0, queue.Size());
    }
}