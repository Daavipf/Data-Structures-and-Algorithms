/*
namespace DSA;

public class LinkedListRecursive<T> : IList<T>
{
    protected T? data;
    protected LinkedListRecursive<T>? next;

    public int Count { get; private set; }

    public LinkedListRecursive()
    {
        Count = 0;
    }

    private bool IsEmpty()
    {
        return data == null;
    }

    public void Append(T element)
    {
        if (this.IsEmpty())
        {
            data = element;
            next = new LinkedListRecursive<T>();
        }
        else
        {
            next.Append(element);
        }

        Count++;
    }
}
*/
