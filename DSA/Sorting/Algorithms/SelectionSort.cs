namespace DSA;

public class SelectionSort : Sorting
{
    public void Sort(int[] array)
    {
        int size = array.Length;

        for (int i = 0; i < size; i++)
        {
            int smaller = i;
            for (int j = i + 1; j < size; j++)
            {
                if (array[j] < array[smaller])
                {
                    smaller = j;
                }
            }

            if (smaller != i)
                Util.Swap(array, smaller, i);
        }
    }
}