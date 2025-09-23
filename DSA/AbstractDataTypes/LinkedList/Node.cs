namespace DSA;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }

    public bool IsEmpty()
    {
        return Data == null;
    }
}
