namespace DSA;

public class BTNode<T>
{
    public T? Data { get; set; }
    public BTNode<T>? Left { get; set; }
    public BTNode<T>? Right { get; set; }
    //public BTNode<T>? Parent { get; set; }

    public BTNode(T data)
    {
        Data = data;
    }

    public BTNode(T data, BTNode<T>? left, BTNode<T>? right/*, BTNode<T>? parent*/)
    {
        Data = data;
        Left = left;
        Right = right;
        //Parent = parent;
    }
}
