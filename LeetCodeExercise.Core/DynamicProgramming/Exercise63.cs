namespace LeetCodeExercise.Core.DynamicProgramming;

public static class Exercise63
{
    public static int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        return FindAnswer(
            obstacleGrid,
            obstacleGrid.Length - 1,
            obstacleGrid[^1].Length - 1,
            new Dictionary<string, int>()
        );
    }

    private static int FindAnswer(int[][] obstacleGrid, int x, int y, Dictionary<string, int> cache)
    {
        if (obstacleGrid[x][y] == 1)
        {
            return 0;
        }

        if (x + y == 0)
        {
            return 1;
        }

        string cacheKey = $"{x}-{y}";
        if (cache.TryGetValue(cacheKey, out int cachedPath))
        {
            return cachedPath;
        }

        int paths = x > 0 ? FindAnswer(obstacleGrid, x - 1, y, cache) : 0;
        paths += y > 0 ? FindAnswer(obstacleGrid, x, y - 1, cache) : 0;
        cache[cacheKey] = paths;

        return paths;
    }
}
