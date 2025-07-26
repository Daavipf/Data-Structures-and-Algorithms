namespace DSA;

public class Util
{
    public static void Swap(int[] array, int left, int right)
    {
        (array[right], array[left]) = (array[left], array[right]);
    }

    public static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}