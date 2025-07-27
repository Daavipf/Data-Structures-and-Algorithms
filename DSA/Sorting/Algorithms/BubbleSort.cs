namespace DSA;

public class BubbleSort : Sorting
{
    public void Sort(int[] array)
    {
        int size = array.Length;
        bool swapped;
        for (int i = 0; i < size; i++)
        {
            swapped = false;
            for (int j = 0; j < size - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    Util.Swap(array, j, j + 1);
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }

    public override string ToString() => "BubbleSort";
}