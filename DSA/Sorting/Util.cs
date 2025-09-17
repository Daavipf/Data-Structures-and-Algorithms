namespace DSA;

public class Util<T>
{
    public static void Swap(T[] array, int left, int right)
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

    public static int FindGreaterElement(int[] array)
    {
        int greater = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > greater)
            {
                greater = array[i];
            }
        }

        return greater;
    }
}