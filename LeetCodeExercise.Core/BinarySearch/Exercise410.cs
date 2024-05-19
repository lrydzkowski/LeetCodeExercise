namespace LeetCodeExercise.Core.BinarySearch;

public static class Exercise410
{
    public static int SplitArray(int[] nums, int k)
    {
        if (k == 1)
        {
            return nums.Sum();
        }

        int left = 0;
        int right = nums.Sum();
        while (left <= right)
        {
            int mid = (int)Math.Floor((left + right) / 2m);
            if (CanFindAnswer(nums, k, mid))
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

    private static bool CanFindAnswer(int[] nums, int k, int value)
    {
        if (nums.Length == 0)
        {
            return false;
        }

        int currentSum = nums[0];
        int currentLength = k - 1;
        List<int> sums = [];
        for (int i = 1; i < nums.Length; i++)
        {
            int num = nums[i];
            if (currentSum + num > value || nums.Length - i == currentLength)
            {
                sums.Add(currentSum);
                currentSum = 0;
                currentLength--;
            }

            currentSum += num;
        }

        sums.Add(currentSum);

        return sums.Count == k && sums.Max() <= value && sums.All(x => x <= value);
    }
}
