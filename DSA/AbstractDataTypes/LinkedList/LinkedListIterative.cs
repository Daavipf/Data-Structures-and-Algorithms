namespace DSA;

public class SinglyLinkedListIt<T> : IList<T> where T : IComparable<T>
{
    public Node<T>? Head { get; private set; }
    public int Count { get; private set; }

    public SinglyLinkedListIt()
    {
        Head = null;
        Count = 0;
    }

    public void InsertLast(T element)
    {
        Node<T> current = Head;
        Node<T> newNode = new Node<T>(element);

        if (Head == null)
        {
            Head = newNode;
            Count++;
        }
        else
        {
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            Count++;
        }
    }

    public void InsertFirst(T element)
    {
        Node<T> newNode = new Node<T>(element);

        if (Head == null)
        {
            Head = newNode;
            Count++;
        }
        else
        {
            Node<T> tmp = Head;
            Head = newNode;
            newNode.Next = tmp;
            Count++;
        }
    }
    public void InsertAt(T element, int index)
    {
        Node<T> current = Head;
        Node<T> newNode = new Node<T>(element);

        if (index < 0 || index > Count)
        {
            throw new IndexOutOfRangeException("Invalid index");
        }

        if (index == 0)
        {
            newNode.Next = Head;
            Head = newNode;
        }
        else
        {
            Node<T> previous = Head;
            for (int j = 0; j < index - 1; j++)
            {
                previous = previous.Next;
            }

            newNode.Next = previous.Next;
            previous.Next = newNode;
        }

        Count++;
    }

    public T Search(T element)
    {
        if (Count == 0)
        {
            throw new ArgumentOutOfRangeException(null, "The list is empty");
        }

        Node<T> current = Head;

        while (current != null)
        {
            if (current.Data.CompareTo(element) == 0)
            {
                return current.Data;
            }

            current = current.Next;
        }

        throw new ArgumentOutOfRangeException(null, "Element not found");
    }

    /*public T RemoveLast()
    {
        T r;
        return r;
    }
    public T RemoveFirst() { }
    public T Remove(T element) { }*/

    public T[] ToArray()
    {
        T[] result = new T[Count];
        Node<T> current = Head!;
        int i = 0;

        while (i < Count)
        {
            result[i] = current!.Data;
            i++;
            current = current.Next!;
        }

        return result;
    }
}
