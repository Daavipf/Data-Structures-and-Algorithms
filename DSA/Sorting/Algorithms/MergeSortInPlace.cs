namespace DSA;

public class MergeSortInPlace : Sorting
{
    public void Sort(int[] array)
    {
        int[] aux = new int[array.Length];
        MergeSortMethod(array, aux, 0, array.Length - 1);
    }

    private void MergeSortMethod(int[] array, int[] aux, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int mid = left + (right - left) / 2;

        MergeSortMethod(array, aux, left, mid);
        MergeSortMethod(array, aux, mid + 1, right);
        Merge(array, aux, left, mid, right);
    }

    private void Merge(int[] array, int[] aux, int left, int mid, int right)
    {
        for (int i = left; i <= right; i++)
        {
            aux[i] = array[i];
        }

        int iLeft = left;
        int iRight = mid + 1;
        int iPlace = left;

        (iLeft, iRight, iPlace) = CompareIndexesAndMerge(array, aux, iLeft, mid, iRight, right, iPlace);

        CopyRestOfArray(array, aux, iRight, right, iPlace);
        CopyRestOfArray(array, aux, iLeft, mid, iPlace);

    }

    private (int, int, int) CompareIndexesAndMerge(int[] array, int[] aux, int iLeft, int mid, int iRight, int right, int iPlace)
    {
        while (iLeft <= mid && iRight <= right)
        {
            if (aux[iLeft] < aux[iRight])
            {
                array[iPlace] = aux[iLeft];
                iLeft++;
            }
            else
            {
                array[iPlace] = aux[iRight];
                iRight++;
            }
            iPlace++;
        }

        return (iLeft, iRight, iPlace);
    }

    private void CopyRestOfArray(int[] array, int[] aux, int index, int end, int iPlace)
    {
        while (index <= end)
        {
            array[iPlace] = aux[index];
            index++;
            iPlace++;
        }
    }
}