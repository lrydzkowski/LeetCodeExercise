namespace LeetCodeExercise;

internal class Exercise1438
{
    public int LongestSubarray(int[] nums, int limit)
    {
        int answer = -1;
        if (nums.Length == 0)
        {
            return answer;
        }

        List<int> min = new();
        List<int> max = new();
        int leftIndex = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            AddToMin(nums, rightIndex, min);
            AddToMax(nums, rightIndex, max);

            while (leftIndex < rightIndex && Math.Abs(nums[min[0]] - nums[max[0]]) > limit)
            {
                if (min[0] < leftIndex)
                {
                    min.RemoveAt(0);
                }

                if (max[0] < leftIndex)
                {
                    max.RemoveAt(0);
                }

                leftIndex++;
            }

            int difference = Math.Abs(nums[max[0]] - nums[min[0]]);
            if (difference <= limit)
            {
                answer = Math.Max(answer, rightIndex - leftIndex + 1);
            }
        }

        return answer;
    }

    private void AddToMin(int[] nums, int index, List<int> min)
    {
        while (min.Count > 0 && nums[min[^1]] > nums[index])
        {
            min.RemoveAt(min.Count - 1);
        }

        min.Add(index);
    }

    private void AddToMax(int[] nums, int index, List<int> max)
    {
        while (max.Count > 0 && nums[max[^1]] < nums[index])
        {
            max.RemoveAt(max.Count - 1);
        }

        max.Add(index);
    }
}
