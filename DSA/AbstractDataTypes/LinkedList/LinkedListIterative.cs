/*
namespace DSA;

public class LinkedListIterative<T> : IList<T>
{
    public Node<T>? Head { get; set; }
    public int Count { get; private set; }

    public LinkedListIterative()
    {
        Count = 0;
    }

    public void Append(T element)
    {
        if (Head == null)
        {
            Head = new Node<T>(element);
        }
        else
        {
            Node<T> currentNode = Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = new Node<T>(element);
        }

        Count++;
    }

    public void InsertAtBeginning(T element)
    {
        if (Head == null)
        {
            Head = new Node<T>(element);
        }
        else
        {
            Node<T> auxNode = Head;
            Node<T> newNode = new Node<T>(element);
            newNode.Next = auxNode;
            Head = newNode;
        }

        Count++;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > Count)
        {
            throw new InvalidOperationException("Invalid index");
        }

        if (Head == null)
        {
            Head = new Node<T>(element);
        }
        else if (index == 0)
        {
            InsertAtBeginning(element);
        }
        else
        {
            Node<T> currentNode = Head;
            int i = 0;
            while (currentNode.Next != null && i < index - 1)
            {
                currentNode = currentNode.Next;
                i++;
            }
            currentNode.Next = new Node<T>(element);

        }

        Count++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException("Element not found");
        }

        Node<T> currentNode = Head;
        int i = 0;
        while (i < index)
        {
            currentNode = currentNode.Next;
            i++;
        }
        return currentNode.Data;
    }

    public bool Search(T element)
    {
        Node<T> currentNode = Head;
        while (currentNode != null)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Data, element))
            {
                return true;
            }
            currentNode = currentNode.Next;
        }
        return false;
    }

    public T Remove(T element)
    {
        if (!Search(element))
        {
            throw new InvalidOperationException("Element not Found");
        }

        Node<T> currentNode = Head;
        Node<T> result = currentNode;
        while (currentNode != null)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Data, element))
            {
                currentNode.Data = currentNode.Next.Data;
                currentNode.Next = currentNode.Next.Next;
                result = currentNode;
                break;
            }
            currentNode = currentNode.Next;
        }

        Count--;

        return result.Data;
    }
}
*/
