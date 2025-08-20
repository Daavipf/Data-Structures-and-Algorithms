namespace DSA;

public class Queue<T>
{
    private T[] array;
    private const int defaultSize = 10;
    private int nextAvailableIndex = -1;

    public Queue()
    {
        array = new T[defaultSize];
    }

    public Queue(int size)
    {
        array = new T[size];
    }

    public bool IsEmpty()
    {
        return nextAvailableIndex == -1;
    }

    private bool IsFull()
    {
        return nextAvailableIndex == array.Length - 1;
    }

    public void Enqueue(T element)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("A fila está cheia");
        }
        nextAvailableIndex++;
        array[nextAvailableIndex] = element;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila está vazia");
        }

        return array[0];
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila está vazia");
        }

        T result = array[0];
        ShiftElements(array);
        nextAvailableIndex--;
        return result;
    }

    private void ShiftElements(T[] array)
    {
        for (int i = 0; i < nextAvailableIndex; i++)
        {
            (array[i], array[i + 1]) = (array[i + 1], array[i]);
        }
    }

    public int Size()
    {
        return nextAvailableIndex + 1;
    }
}