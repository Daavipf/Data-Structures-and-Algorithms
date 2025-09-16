namespace DSA;

public interface IList<T>
{
    int Count { get; }
    void Append(T element);
    void InsertAtBeginning(T element);
    void InsertAt(T element, int index);
    T Get(int index);
    bool Search(T element);
    T Remove(T element);
}
