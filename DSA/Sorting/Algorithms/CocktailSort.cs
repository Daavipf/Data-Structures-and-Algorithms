namespace DSA;

public class CocktailSort : Sorting
{
    public void Sort(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;
        bool swapped = true;

        while (swapped)
        {
            swapped = false;
            for (int i = start; i < end; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Util.Swap(array, i, i + 1);
                    swapped = true;
                }
            }

            if (!swapped) break;

            swapped = false;
            end--;
            for (int i = end; i > start; i--)
            {
                if (array[i] < array[i - 1])
                {
                    Util.Swap(array, i, i - 1);
                    swapped = true;
                }
            }
            start++;
        }
    }

    public override string ToString() => "CocktailSort";
}