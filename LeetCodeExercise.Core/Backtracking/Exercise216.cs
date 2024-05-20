namespace LeetCodeExercise.Core.Backtracking;

public static class Exercise216
{
    public static IList<IList<int>> CombinationSum3(int k, int n)
    {
        List<List<int>> results = FindResults(k, n, 0, new List<int>(), new List<List<int>>());

        return results.Select(x => new HashSet<int>(x))
            .Distinct(HashSet<int>.CreateSetComparer())
            .Select(x => (IList<int>)x.ToList())
            .ToList();
    }

    private static List<List<int>> FindResults(int k, int n, int currentSum, List<int> path, List<List<int>> results)
    {
        if (path.Count == k && currentSum == n)
        {
            results.Add(path.Select(x => x).ToList());

            return results;
        }

        for (int i = 1; i <= 9; i++)
        {
            if (currentSum + i > n)
            {
                break;
            }

            if (path.Contains(i))
            {
                continue;
            }

            path.Add(i);
            results = FindResults(k, n, currentSum + i, path, results);
            path.RemoveAt(path.Count - 1);
        }

        return results;
    }
}
