namespace DSA;

public class CountingSort : Sorting
{
    public void Sort(int[] array)
    {
        if (array.Length > 0)
        {
            int[] countingArray = PopulateCountingArray(array);

            WriteSortedValuesToArray(array, countingArray);
        }
    }

    private int[] PopulateCountingArray(int[] array)
    {
        int greater = Util<int>.FindGreaterElement(array);

        int[] countingArray = new int[greater + 1];
        for (int k = 0; k < array.Length; k++)
        {
            countingArray[array[k]]++;
        }

        return countingArray;
    }

    private void WriteSortedValuesToArray(int[] array, int[] countingArray)
    {
        int index = 0;
        for (int j = 0; j < countingArray.Length; j++)
        {
            while (countingArray[j] > 0)
            {
                array[index] = j;
                index++;
                countingArray[j]--;
            }
        }
    }

    public override string ToString() => "CountingSort";
}