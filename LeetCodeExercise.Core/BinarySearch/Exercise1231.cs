namespace LeetCodeExercise.Core.BinarySearch;

public static class Exercise1231
{
    public static int MaximizeSweetness(int[] sweetness, int k)
    {
        if (k == 0)
        {
            return sweetness.Sum();
        }

        int left = 1;
        int right = (int)Math.Ceiling((decimal)sweetness.Sum() / k);
        while (left <= right)
        {
            int mid = (int)Math.Floor((left + right) / 2m);
            if (FulfillRequirements(sweetness, k, mid))
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return right;
    }

    private static bool FulfillRequirements(int[] sweetness, int k, int value)
    {
        int currentSum = 0;
        int parts = 0;
        foreach (int currentValue in sweetness)
        {
            currentSum += currentValue;
            if (currentSum >= value)
            {
                currentSum = 0;
                parts++;
            }
        }

        if (parts >= k + 1)
        {
            return true;
        }

        return false;
    }
}
