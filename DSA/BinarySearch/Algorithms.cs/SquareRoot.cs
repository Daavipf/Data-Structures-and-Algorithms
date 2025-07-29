namespace DSA;

public class SquareRoot
{
    public static int Sqrt(int target)
    {
        if (target < 0)
        {
            throw new ArgumentException("Target não pode ser negativo");
        }
        if (target == 0 || target == 1)
        {
            return target;
        }

        return BinarySearch(0, target, target);
    }

    private static int BinarySearch(int left, int right, int target)
    {
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;

            if (square == target)
            {
                return mid;
            }
            else if (square < target)
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}