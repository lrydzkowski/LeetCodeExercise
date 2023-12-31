﻿namespace LeetCodeExercise.Core.Monotonic;

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

            if (heights[index - 1] < height)
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

    public static int[] RunSlow2(int[] heights)
    {
        int[] results = new int[heights.Length];
        for (int index = 0; index < heights.Length - 1; index++)
        {
            int height = heights[index];

            int nextIndex = index + 1;
            if (height < heights[nextIndex])
            {
                results[index] = 1;

                continue;
            }

            Stack<int> stack = new();
            stack.Push(nextIndex);
            nextIndex++;
            while (nextIndex < heights.Length && height > heights[stack.Peek()])
            {
                if (heights[nextIndex] > heights[stack.Peek()])
                {
                    stack.Push(nextIndex);
                }

                nextIndex++;
            }

            results[index] = stack.Count;
        }

        return results;
    }

    public static int[] RunSlow3(int[] heights)
    {
        int[] results = new int[heights.Length];
        Stack<int> stack = new();
        for (int index = heights.Length - 1; index >= 0; index--)
        {
            int height = heights[index];

            int count = stack.Count(x => height > x);
            if (stack.Any(x => height < x))
            {
                count++;
            }

            results[index] = count;


            while (stack.Count > 0 && height > stack.Peek())
            {
                stack.Pop();
            }

            stack.Push(height);
        }

        return results;
    }
}
