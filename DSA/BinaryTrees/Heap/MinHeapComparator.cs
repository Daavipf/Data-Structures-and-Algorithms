namespace DSA;

public class MinHeapComparator<T> : Comparator<T> where T : IComparable<T>
{
    public int Compare(T o1, T o2)
    {
        return o2.CompareTo(o1);
    }
}