namespace LeetCodeExercise.Core.Graphs;

public static class Exercise2101
{
    public static int MaximumDetonation(int[][] bombs)
    {
        if (bombs.Length == 0)
        {
            return 0;
        }

        List<List<int>> graph = BuildGraph(bombs);
        int response = 0;
        for (int i = 0; i < bombs.Length; i++)
        {
            Dictionary<int, bool> seen = new() { [i] = true };
            response = Math.Max(response, TraverseGraph(i, graph, seen));
        }

        return response;
    }

    private static List<List<int>> BuildGraph(int[][] bombs)
    {
        List<List<int>> graph = new();
        for (int i = 0; i < bombs.Length; i++)
        {
            graph.Add(new List<int>());
            int[] currentBomb = bombs[i];
            for (int j = 0; j < bombs.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                int[] bombToCompare = bombs[j];
                if (!CanTrigger(currentBomb, bombToCompare))
                {
                    continue;
                }

                graph[i].Add(j);
            }
        }

        return graph;
    }

    private static bool CanTrigger(int[] leftBomb, int[] rightBomb)
    {
        long dx = Math.Abs(rightBomb[0] - leftBomb[0]);
        long dy = Math.Abs(rightBomb[1] - leftBomb[1]);
        long r = leftBomb[2];

        if (dx + dy <= r)
        {
            return true;
        }

        if (dx > r || dy > r)
        {
            return false;
        }

        if (dx * dx + dy * dy <= r * r)
        {
            return true;
        }

        return false;
    }

    private static int TraverseGraph(int node, List<List<int>> graph, Dictionary<int, bool> seen, int level = 0)
    {
        level++;
        foreach (int nextNode in graph[node])
        {
            if (!seen.TryAdd(nextNode, true))
            {
                continue;
            }

            level = Math.Max(level, TraverseGraph(nextNode, graph, seen, level));
        }

        return level;
    }
}
