namespace DSA;

public interface Comparator<T> where T : IComparable<T>
{
    int Compare(T o1, T o2);
}