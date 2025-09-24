namespace DSA;

public class SinglyLinkedListIt<T>
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
        Node<T> current = Head!;
        Node<T> newNode = new Node<T>(element);

        if (Head == null)
        {
            Head = newNode;

        }
        else
        {
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        Count++;
    }

    public void InsertFirst(T element)
    {
        Node<T> newNode = new Node<T>(element);

        newNode.Next = Head;
        Head = newNode;
        Count++;
    }
    public void InsertAt(T element, int index)
    {
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
            throw new InvalidOperationException("The list is empty");
        }

        Node<T> current = Head;

        while (current != null)
        {
            if (Equals(current.Data, element))
            {
                return current.Data;
            }

            current = current.Next;
        }

        throw new KeyNotFoundException("Element not found");
    }

    public T RemoveLast()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("The list is empty");
        }

        T result = Head.Data;

        if (Head.Next == null)
        {
            result = Head.Data;
            Head = null;
        }
        else
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                if (current.Next.Next == null)
                {
                    result = current.Next.Data;
                    current.Next = null;
                    break;
                }

                current = current.Next;
            }
        }

        Count--;
        return result;
    }
    public T RemoveFirst()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("The list is empty");
        }

        T result = Head.Data;

        Head = Head.Next;

        Count--;
        return result;
    }
    public T Remove(T element)
    {
        if (Head == null)
        {
            throw new InvalidOperationException("The list is empty");
        }

        if (Equals(Head.Data, element))
        {
            T result = Head.Data;
            Head = Head.Next;
            Count--;
            return result;
        }

        Node<T> current = Head;
        while (current.Next != null)
        {
            if (Equals(current.Next.Data, element))
            {
                T result = current.Next.Data;
                current.Next = current.Next.Next;
                Count--;
                return result;
            }
            current = current.Next;
        }

        throw new KeyNotFoundException("Element not found");

    }

    public T[] ToArray()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("The list is empty");
        }

        T[] result = new T[Count];
        Node<T> current = Head;
        int i = 0;

        while (i < Count)
        {
            result[i] = current.Data;
            i++;
            current = current.Next;
        }

        return result;
    }
}
