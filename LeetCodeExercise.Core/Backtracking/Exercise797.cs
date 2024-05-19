namespace LeetCodeExercise.Core.Backtracking;

public static class Exercise797
{
    public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        List<List<int>> answers = GoThroughGraph(graph, 0, [0], new List<List<int>>());

        return answers.Select(x => x).Cast<IList<int>>().ToList();
    }

    private static List<List<int>> GoThroughGraph(int[][] graph, int index, List<int> path, List<List<int>> answers)
    {
        if (index == graph.Length - 1)
        {
            answers.Add(path.Select(x => x).ToList());

            return answers;
        }

        foreach (int nextIndex in graph[index])
        {
            path.Add(nextIndex);
            answers = GoThroughGraph(graph, nextIndex, path, answers);
            path.RemoveAt(path.Count - 1);
        }

        return answers;
    }
}
