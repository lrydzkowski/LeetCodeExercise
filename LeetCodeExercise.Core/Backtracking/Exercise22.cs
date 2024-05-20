namespace LeetCodeExercise.Core.Backtracking;

public static class Exercise22
{
    public static IList<string> GenerateParenthesis(int n)
    {
        IList<string> results = FindAnswers(n, n, new List<char>(), new List<string>());

        return results;
    }

    private static IList<string> FindAnswers(int openings, int closures, List<char> path, IList<string> results)
    {
        if (openings > 0)
        {
            path.Add('(');
            results = FindAnswers(openings - 1, closures, path, results);
            path.RemoveAt(path.Count - 1);
        }

        if (closures > openings)
        {
            path.Add(')');
            results = FindAnswers(openings, closures - 1, path, results);
            path.RemoveAt(path.Count - 1);
        }

        if (openings == 0 && closures == 0)
        {
            results.Add(string.Join("", path));
        }

        return results;
    }
}
