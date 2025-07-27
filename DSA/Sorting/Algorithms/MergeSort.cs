namespace DSA;

public class MergeSort : Sorting
{
    public void Sort(int[] array)
    {
        int[] result = MergeSortMethod(array);
        Array.Copy(result, array, result.Length);
    }

    private int[] MergeSortMethod(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int mid = array.Length / 2;

        int[] leftHalf = MergeSortMethod(array[..mid]);
        int[] rightHalf = MergeSortMethod(array[mid..]);

        return Merge(leftHalf, rightHalf);
    }

    private int[] Merge(int[] leftHalf, int[] rightHalf)
    {
        int[] result = new int[leftHalf.Length + rightHalf.Length];

        CompareElementsAndMerge(leftHalf, rightHalf, result);

        return result;
    }

    private void CompareElementsAndMerge(int[] leftHalf, int[] rightHalf, int[] result)
    {
        int i = 0, j = 0, k = 0;
        while (i < leftHalf.Length && j < rightHalf.Length)
        {
            if (leftHalf[i] <= rightHalf[j])
            {
                result[k++] = leftHalf[i++];
            }
            else
            {
                result[k++] = rightHalf[j++];
            }
        }

        CopyRestOfArray(result, leftHalf, i, k);
        CopyRestOfArray(result, rightHalf, j, k);

    }

    private void CopyRestOfArray(int[] result, int[] half, int iHalf, int iPlace)
    {
        while (iHalf < half.Length)
        {
            result[iPlace++] = half[iHalf++];
        }
    }

    public override string ToString() => "MergeSort";
}