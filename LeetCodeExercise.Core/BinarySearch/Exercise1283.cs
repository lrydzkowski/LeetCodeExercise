namespace LeetCodeExercise.Core.BinarySearch;

public static class Exercise1283
{
    public static int SmallestDivisor(int[] nums, int threshold)
    {
        int left = 1;
        int right = nums.Max();
        while (left <= right)
        {
            int mid = (int)Math.Floor((left + right) / 2m);
            if (Check(nums, threshold, mid))
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    private static bool Check(int[] nums, int threshold, int divider)
    {
        int sum = 0;
        foreach (int num in nums)
        {
            sum += (int)Math.Ceiling((decimal)num / divider);
            if (sum > threshold)
            {
                return false;
            }
        }

        return true;
    }
}
