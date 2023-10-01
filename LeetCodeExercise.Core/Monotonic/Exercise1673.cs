namespace LeetCodeExercise.Core.Monotonic;

public static class Exercise1673
{
    public static int[] ExecuteSlow(int[] numbers, int k)
    {
        Stack<int> monotonicStack = new();

        int index = 0;
        for (int i = 0; i < k; i++)
        {
            for (int j = index; j < numbers.Length - k + i + 1; j++)
            {
                int number = numbers[j];
                while (monotonicStack.Count > i && monotonicStack.Peek() > number)
                {
                    monotonicStack.Pop();
                }

                if (monotonicStack.Count < i + 1)
                {
                    monotonicStack.Push(number);
                    index = j + 1;
                }
            }
        }

        return monotonicStack.ToArray().Reverse().ToArray();
    }

    public static int[] ExecuteFast(int[] numbers, int k)
    {
        Stack<int> monotonicStack = new();

        for (int j = 0; j < numbers.Length; j++)
        {
            int number = numbers[j];
            while (monotonicStack.Count > 0
                   && monotonicStack.Peek() > number
                   && numbers.Length - j > k - monotonicStack.Count)
            {
                monotonicStack.Pop();
            }

            if (monotonicStack.Count < k)
            {
                monotonicStack.Push(number);
            }
        }

        return monotonicStack.ToArray().Reverse().ToArray();
    }
}
