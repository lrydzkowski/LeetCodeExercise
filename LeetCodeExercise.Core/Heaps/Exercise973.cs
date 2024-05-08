namespace LeetCodeExercise.Core.Heaps;

public static class Exercise973
{
    public static int[][] Calculate(int[][] points, int k)
    {
        PriorityQueue<int[], double> priorityQueue = new();
        foreach (int[] point in points)
        {
            int xDistance = point[0] - 0;
            int yDistance = point[1] - 0;
            double priority = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));
            priorityQueue.Enqueue(point, priority);
        }

        List<int[]> results = new();
        for (int i = 0; i < k; i++)
        {
            results.Add(priorityQueue.Dequeue());
        }

        return results.ToArray();
    }
}
