namespace LeetCodeExercise.Core.Greedy;

public static class Exercise1338
{
    public static int MinSetSize(int[] arr)
    {
        Dictionary<int, int> occurrences = new();
        foreach (int val in arr)
        {
            occurrences.TryAdd(val, 0);
            occurrences[val]++;
        }

        int operations = 0;
        int currentLength = arr.Length;
        int halfLength = currentLength / 2;
        List<int[]> elements =
            occurrences.Select(x => new[] { x.Key, x.Value }).OrderByDescending(x => x[1]).ToList();
        foreach (int[] element in elements)
        {
            currentLength -= element[1];
            operations++;
            if (currentLength <= halfLength)
            {
                break;
            }
        }

        return operations;
    }
}
