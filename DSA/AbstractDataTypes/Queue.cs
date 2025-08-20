namespace DSA;

public class Queue<T>
{
    private T[] array;
    private const int defaultSize = 10;
    private int head = 0;
    private int tail = 0;
    private int count = 0;

    public Queue()
    {
        array = new T[defaultSize];
    }

    public Queue(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentOutOfRangeException("Tamanho da fila não pode ser negativo");
        }
        array = new T[size];
    }

    public int Count => count;

    public bool IsEmpty => count == 0;

    private bool IsFull => count == array.Length;

    public void Enqueue(T element)
    {
        if (IsFull)
        {
            throw new InvalidOperationException("A fila está cheia");
        }

        array[tail] = element;
        tail = (tail + 1) % array.Length;
        count++;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("A fila está vazia");
        }

        return array[head];
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("A fila está vazia");
        }

        T result = array[head];
        head = (head + 1) % array.Length;
        count--;
        return result;
    }
}