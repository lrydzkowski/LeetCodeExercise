namespace LeetCodeExercise.Core.Backtracking;

public static class Exercise967
{
    public static int[] NumsSameConsecDiff(int n, int k)
    {
        List<string> results = FindAnswers(n, k, new List<int>(), new List<string>());

        return results.Select(x => Convert.ToInt32(x)).ToArray();
    }

    private static List<string> FindAnswers(int n, int k, List<int> path, List<string> results)
    {
        if (path.Count == n)
        {
            results.Add(string.Join("", path));

            return results;
        }

        if (path.Count == 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                path.Add(i);
                results = FindAnswers(n, k, path, results);
                path.RemoveAt(path.Count - 1);
            }

            return results;
        }

        int current = path[^1];
        if (current - k >= 0)
        {
            path.Add(current - k);
            results = FindAnswers(n, k, path, results);
            path.RemoveAt(path.Count - 1);
        }

        if (k > 0 && current + k <= 9)
        {
            path.Add(current + k);
            results = FindAnswers(n, k, path, results);
            path.RemoveAt(path.Count - 1);
        }

        return results;
    }
}
