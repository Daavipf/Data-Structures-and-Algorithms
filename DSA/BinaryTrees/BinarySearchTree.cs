namespace DSA;

public class BinarySearchTree<T> : IBinaryTree<T> where T : IComparable<T>
{
    public BTNode<T>? Root { get; set; }

    public BinarySearchTree() { }

    public void Insert(T element)
    {
        Root = Insert(element, Root);
    }

    private BTNode<T>? Insert(T element, BTNode<T>? node)
    {
        if (node is null)
        {
            return new BTNode<T>(element);
        }
        else if (element.CompareTo(node.Data) > 0)
        {
            node.Right = Insert(element, node.Right);
        }
        else if (element.CompareTo(node.Data) < 0)
        {
            node.Left = Insert(element, node.Left);
        }

        return node;
    }

    public T Search(T element)
    {
        return Search(element, Root);
    }

    private T Search(T element, BTNode<T>? node)
    {
        if (node is null)
        {
            throw new Exception("Element not found");
        }

        if (element.CompareTo(node.Data) == 0)
        {
            return element;
        }
        else if (element.CompareTo(node.Data) > 0)
        {
            return Search(element, node.Right);
        }
        else
        {
            return Search(element, node.Left);
        }
    }

    public void Remove(T element)
    {
        Root = Remove(element, Root);
    }

    private BTNode<T>? Remove(T element, BTNode<T>? node)
    {
        if (node is null)
        {
            throw new Exception("Element not found");
        }

        if (element.CompareTo(node.Data) > 0)
        {
            node.Right = Remove(element, node.Right);
        }
        else if (element.CompareTo(node.Data) < 0)
        {
            node.Left = Remove(element, node.Left);
        }
        else
        {
            if (node.Left is null)
            {
                return node.Right;
            }
            else if (node.Right is null)
            {
                return node.Left;
            }

            T successor = Successor(node);
            node.Data = successor;
            node.Right = Remove(successor, node.Right);
        }

        return node;
    }

    public T Successor(BTNode<T> node)
    {
        BTNode<T> current = node.Right;
        while (current.Left is not null)
        {
            current = current.Left;
        }

        return current.Data;
    }

    public T Predecessor(BTNode<T> node)
    {
        BTNode<T> current = node.Left;
        while (current.Right is not null)
        {
            current = current.Right;
        }

        return current.Data;
    }

    public List<T> InOrder()
    {
        List<T> result = new List<T>();
        InOrder(Root, result);
        return result;
    }

    private void InOrder(BTNode<T>? node, List<T> list)
    {
        if (node is null)
        {
            return;
        }

        InOrder(node.Left, list);
        list.Add(node.Data);
        InOrder(node.Right, list);
    }

    public List<T> PreOrder()
    {
        List<T> result = new List<T>();
        PreOrder(Root, result);
        return result;
    }

    private void PreOrder(BTNode<T>? node, List<T> list)
    {
        if (node is null)
        {
            return;
        }

        list.Add(node.Data);
        PreOrder(node.Left, list);
        PreOrder(node.Right, list);
    }

    public List<T> PostOrder()
    {
        List<T> result = new List<T>();
        PostOrder(Root, result);
        return result;
    }

    private void PostOrder(BTNode<T>? node, List<T> list)
    {
        if (node is null)
        {
            return;
        }

        PostOrder(node.Left, list);
        PostOrder(node.Right, list);
        list.Add(node.Data);
    }
}
