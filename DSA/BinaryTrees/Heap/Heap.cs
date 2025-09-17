namespace DSA;

public class Heap<T> where T : IComparable<T>
{
    private T[] heap;
    private int Index = -1;
    private Comparator<T> Comparator;

    private const int INITIAL_SIZE = 20;
    private const int INCREASING_FACTOR = 10;

    public Heap(Comparator<T> comparator)
    {
        heap = new T[INITIAL_SIZE];
        Comparator = comparator;
    }

    public bool IsEmpty()
    {
        return Index == -1;
    }

    private int Parent(int i)
    {
        return (i - 1) / 2;
    }

    private int Left(int i)
    {
        return (i * 2) + 1;
    }

    private int Right(int i)
    {
        return (i * 2) + 2;
    }

    public T[] ToArray()
    {
        List<T> result = new List<T>();
        for (int i = 0; i < Index; i++)
        {
            result.Add(heap[i]);
        }

        return result.ToArray();
    }

    public T Root()
    {
        return heap[0];
    }

    public void Insert(T element)
    {
        if (Index == heap.Length - 1)
        {
            Array.Resize(ref heap, heap.Length + INCREASING_FACTOR);
        }

        Index++;
        heap[Index] = element;


    }

    private void Heapify(int position)
    {
        int left = Left(position);
        int right = Right(position);
        int best = position;

        if (left <= Index && Comparator.Compare(heap[left], heap[best]) < 0)
        {
            best = left;
        }

        // verifica se o filho da direita é "melhor"
        if (right <= Index && Comparator.Compare(heap[right], heap[best]) < 0)
        {
            best = right;
        }

        // se algum filho for melhor, troca e continua heapify
        if (best != position)
        {
            Util<T>.Swap(heap, position, best);
            Heapify(best);
        }
    }
}