namespace LeetCodeExercise.Core.Monotonic;

// https://leetcode.com/problems/number-of-visible-people-in-a-queue/description/
public static class Exercise1944
{
    public static int[] RunSlow(int[] heights)
    {
        int[] results = new int[heights.Length];
        Dictionary<int, Stack<int>> monotonic = new();
        for (int index = 1; index < heights.Length; index++)
        {
            int height = heights[index];

            List<int> keysToRemove = new();
            foreach (KeyValuePair<int, Stack<int>> element in monotonic)
            {
                if (heights[element.Value.Peek()] < height)
                {
                    element.Value.Push(index);
                }

                if (heights[element.Key] < height)
                {
                    results[element.Key] = element.Value.Count;
                    keysToRemove.Add(element.Key);
                }
            }

            foreach (int keyToRemove in keysToRemove)
            {
                monotonic.Remove(keyToRemove);
            }

            if (heights[index - 1] <= height)
            {
                results[index - 1] = 1;
            }
            else
            {
                monotonic[index - 1] = new Stack<int>();
                monotonic[index - 1].Push(index);
            }
        }

        foreach (KeyValuePair<int, Stack<int>> element in monotonic)
        {
            results[element.Key] = element.Value.Count;
        }

        return results;
    }

    public static int[] RunFast(int[] heights)
    {
        int[] results = new int[heights.Length];
        Stack<int> mnemonic = new();
        for (int index = 0; index < heights.Length; index++)
        {
            int height = heights[index];
            while (mnemonic.Count > 0 && heights[mnemonic.Peek()] < height)
            {
                int previousIndex = mnemonic.Pop();
                results[previousIndex] = index - previousIndex;
            }

            mnemonic.Push(index);
        }

        while (mnemonic.Count > 0)
        {
            int previousIndex = mnemonic.Pop();
            results[previousIndex] = heights.Length - 1 - previousIndex;
        }

        return results;
    }
}
