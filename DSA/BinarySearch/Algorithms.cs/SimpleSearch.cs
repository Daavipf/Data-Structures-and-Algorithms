namespace DSA;

public class SimpleSearch : IBinarySearch
{
    public int Search(int[] array, int target)
    {
        int result = BinarySearch(array, 0, array.Length - 1, target);
        return result;
    }

    private static int BinarySearch(int[] array, int left, int right, int target)
    {
        int iResult = -1;
        if (left > right)
        {
            return iResult;
        }

        int mid = left + (right - left) / 2;

        if (array[mid] == target)
        {
            iResult = mid;
        }
        else if (array[mid] > target)
        {
            iResult = BinarySearch(array, left, mid - 1, target);
        }
        else if (array[mid] < target)
        {
            iResult = BinarySearch(array, mid + 1, right, target);
        }

        return iResult;
    }
}