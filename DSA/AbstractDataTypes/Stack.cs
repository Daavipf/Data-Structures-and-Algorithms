namespace DSA;

public class Stack<T>
{
    private T[] array;
    private const int defaultSize = 10;
    private int topIndex = -1;

    public Stack()
    {
        array = new T[defaultSize];
    }

    public Stack(int size)
    {
        array = new T[size];
    }

    public bool IsEmpty()
    {
        return topIndex == -1;
    }

    private bool IsFull()
    {
        return topIndex == array.Length - 1;
    }

    public void Push(T element)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("A pilha está cheia");
        }

        topIndex++;
        array[topIndex] = element;

    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A pilha está vazia");
        }

        int tempIndex = topIndex;
        topIndex--;
        return array[tempIndex];

    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A pilha está vazia");
        }

        return array[topIndex];

    }

    public int Size()
    {
        return topIndex + 1;
    }
}