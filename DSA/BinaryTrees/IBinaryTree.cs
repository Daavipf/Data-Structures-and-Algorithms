namespace DSA;

public interface IBinaryTree<T> where T : IComparable<T>
{
    public void Insert(T element);
    public T Search(T element);
    public void Remove(T element);
    public List<T> InOrder();
    public List<T> PreOrder();
    public List<T> PostOrder();
}
