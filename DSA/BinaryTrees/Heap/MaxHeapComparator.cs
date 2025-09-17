namespace DSA;

public class MaxHeapComparator<T> : Comparator<T> where T : IComparable<T>
{
    public int Compare(T o1, T o2)
    {
        return o1.CompareTo(o2);
    }
}