namespace LeetCodeExercise.Core.Graphs;

public static class Exercise1926
{
    public static int FindNearestExit(char[][] maze, int[] entrance)
    {
        if (maze.Length == 0)
        {
            return -1;
        }

        int steps = 1;

        int[][] directions = { new[] { 0, -1 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 1, 0 } };

        Dictionary<string, bool> seen = new() { [BuildKey(entrance[0], entrance[1])] = true };

        Queue<int[]> elements = new();
        elements.Enqueue(entrance);

        while (elements.Count > 0)
        {
            int elementsLength = elements.Count;
            for (int i = 0; i < elementsLength; i++)
            {
                int[] element = elements.Dequeue();

                foreach (int[] direction in directions)
                {
                    int newY = element[0] + direction[0];
                    if (newY < 0 || newY > maze.Length - 1)
                    {
                        continue;
                    }

                    int newX = element[1] + direction[1];
                    if (newX < 0 || newX > maze[0].Length - 1)
                    {
                        continue;
                    }

                    if (!IsEmptyCell(maze[newY][newX]))
                    {
                        continue;
                    }

                    string key = BuildKey(newY, newX);
                    if (!seen.TryAdd(key, true))
                    {
                        continue;
                    }

                    if (IsExit(newY, newX, maze))
                    {
                        return steps;
                    }

                    elements.Enqueue(new[] { newY, newX });
                }
            }

            steps++;
        }

        return -1;
    }

    private static string BuildKey(int y, int x)
    {
        return $"{y}-{x}";
    }

    private static bool IsEmptyCell(char field)
    {
        return field == '.';
    }

    private static bool IsExit(int y, int x, char[][] maze)
    {
        if (y == 0 || y == maze.Length - 1)
        {
            return true;
        }

        if (x == 0 || x == maze[0].Length - 1)
        {
            return true;
        }

        return false;
    }
}
