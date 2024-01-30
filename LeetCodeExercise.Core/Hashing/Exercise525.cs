namespace LeetCodeExercise.Core.Hashing;

public static class Exercise525
{
    public static int FindMaxLength(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return 0;
        }

        int result = 0;
        Dictionary<int, int> summary = new();
        for (int i = 0; i < nums.Length; i++)
        {
            summary[0] = 0;
            summary[1] = 0;
            for (int j = i; j < nums.Length; j++)
            {
                summary[nums[j]]++;
                if (summary[0] == summary[1])
                {
                    result = Math.Max(result, j - i + 1);
                }
            }
        }

        return result;
    }

    public static int FindMaxLength2(int[] nums)

    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            nums[i] = sum;
        }

        int result = 0;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            int initialValue = nums[i];
            int length = i + 1;
            if (length < result)
            {
                continue;
            }

            if (length % 2 == 0 && initialValue == length / 2)
            {
                result = Math.Max(result, length);

                continue;
            }

            for (int j = 1; j < i; j++)
            {
                int currentValue = initialValue - nums[j - 1];
                length--;
                if (length < result)
                {
                    break;
                }

                if (length % 2 == 0 && currentValue == length / 2)
                {
                    result = Math.Max(result, length);

                    break;
                }
            }
        }

        return result;
    }
}
