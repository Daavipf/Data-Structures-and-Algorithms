namespace DSA;

public interface IList<T>
{
    Node<T>? Head { get; }
    int Count { get; }
    void InsertLast(T element);
    void InsertFirst(T element);
    void InsertAt(T element, int index);
    T Search(T element);
    T[] ToArray();
    /*T RemoveLast();
    T RemoveFirst();
    T Remove(T element);*/
}
