namespace DSA;

public class RadixSort : Sorting
{
    public void Sort(int[] array)
    {
        if (array.Length > 0)
        {
            int greater = Util.FindGreaterElement(array);
            int exp = 1;

            while (greater / exp > 0)
            {
                CountingSortByDigit(array, exp);
                exp *= 10;
            }
        }
    }

    private void CountingSortByDigit(int[] array, int exp)
    {
        int arraySize = array.Length;
        int[] output = new int[arraySize];
        int[] count = new int[10];

        for (int i = 0; i < arraySize; i++)
            count[(array[i] / exp) % 10]++;

        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        for (int i = arraySize - 1; i >= 0; i--)
        {
            int index = (array[i] / exp) % 10;
            output[count[index] - 1] = array[i];
            count[index]--;
        }

        for (int i = 0; i < arraySize; i++)
            array[i] = output[i];
    }
}