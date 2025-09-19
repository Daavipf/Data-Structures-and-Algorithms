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
        for (int i = 0; i <= Index; i++)
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
        SiftUp(Index);
    }

    private void SiftUp(int position)
    {
        if (position == 0 || Comparator.Compare(heap[position], heap[Parent(position)]) <= 0)
        {
            return;
        }

        Util<T>.Swap(heap, position, Parent(position));
        SiftUp(Parent(position));
    }

    private void SiftDown(int position)
    {
        int left = Left(position);
        int right = Right(position);
        int best = position;

        if (left <= Index && Comparator.Compare(heap[left], heap[best]) > 0)
        {
            best = left;
        }

        if (right <= Index && Comparator.Compare(heap[right], heap[best]) > 0)
        {
            best = right;
        }

        if (best != position)
        {
            Util<T>.Swap(heap, position, best);
            SiftDown(best);
        }
    }

    public int Size()
    {
        return Index + 1;
    }

    public void BuildHeap(T[] array)
    {
        if (array is not null)
        {
            heap = array;
            Index = array.Length - 1;

            for (int i = Parent(Index); i >= 0; i--)
            {
                SiftDown(i);
            }
        }
    }

    public T ExtractRoot()
    {
        if (IsEmpty())
        {
            throw new Exception("Heap is empty");

        }

        T result = heap[0];
        Index--;
        heap[0] = heap[Index + 1];
        SiftDown(0);

        return result;
    }

    public void HeapSort(T[] array)
    {
        BuildHeap(array);
        int originalIndex = Index;

        for (int i = Index; i > 0; i--)
        {
            Util<T>.Swap(heap, 0, i);
            Index--;
            SiftDown(0);
        }

        Index = originalIndex;
    }
}