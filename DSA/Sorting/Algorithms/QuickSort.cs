namespace DSA;

public class QuickSort : Sorting
{
    public void Sort(int[] array)
    {
        QuickSortAlgorithm(array, 0, array.Length - 1);
    }

    private void QuickSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            int iPivot = PartitionLomuto(array, left, right);
            QuickSortAlgorithm(array, left, iPivot - 1);
            QuickSortAlgorithm(array, iPivot + 1, right);
        }
    }

    private int PartitionLomuto(int[] array, int left, int right)
    {
        int pivot = array[right];

        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Util.Swap(array, i, j);
            }
        }

        Util.Swap(array, i + 1, right);
        return i + 1;
    }

    private int PartitionHoare(int[] array, int left, int right)
    {
        int pivot = array[left];
        int i = left - 1;
        int j = right + 1;

        while (true)
        {
            do { i++; } while (array[i] < pivot);
            do { j--; } while (array[j] > pivot);

            if (i >= j) return j;

            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}