namespace DSA;

public class SelectionSort : Sorting
{
    public void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int smaller = FindSmallerElement(array, i);

            if (smaller != i)
                Util<int>.Swap(array, smaller, i);
        }
    }

    private int FindSmallerElement(int[] array, int index)
    {
        int smaller = index;
        for (int j = index + 1; j < array.Length; j++)
        {
            if (array[j] < array[smaller])
            {
                smaller = j;
            }
        }

        return smaller;
    }

    public override string ToString() => "SelectionSort";
}