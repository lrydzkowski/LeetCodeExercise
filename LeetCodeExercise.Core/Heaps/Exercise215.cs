namespace LeetCodeExercise.Core.Heaps;

public static class Exercise215
{
    public static int FindKthLargest(int[] numbers, int k)
    {
        PriorityQueue<int, int> priorityQueue = new();
        foreach (int number in numbers)
        {
            priorityQueue.Enqueue(number * -1, number * -1);
        }

        int result = 0;
        for (int i = 0; i < k; i++)
        {
            result = priorityQueue.Dequeue();
        }

        return result * -1;
    }
}
