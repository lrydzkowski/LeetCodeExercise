namespace LeetCodeExercise.Core.BinarySearch;

public static class Exercise2389
{
    public static int[] AnswerQueries(int[] nums, int[] queries)
    {
        nums = nums.OrderBy(x => x).ToArray();
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        List<int> answers = new();
        foreach (int query in queries)
        {
            int currentAnswer = -1;

            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (int)Math.Floor((left + right) / 2m);
                if (nums[mid] == query)
                {
                    currentAnswer = mid + 1;

                    break;
                }

                if (nums[mid] > query)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (currentAnswer == -1)
            {
                currentAnswer = left;
            }

            answers.Add(currentAnswer);
        }

        return answers.ToArray();
    }
}
