namespace LeetCodeExercise.Core.DynamicProgramming;

public static class Exercise931
{
    public static int MinFallingPathSum(int[][] matrix)
    {
        if (matrix.Length == 0)
        {
            return 0;
        }

        Dictionary<string, int> cache = new();
        List<int> possibleValues = new();
        int row = matrix.Length - 1;
        for (int i = 0; i < matrix[row].Length; i++)
        {
            possibleValues.Add(FindAnswer(matrix, row, i, cache));
        }

        return possibleValues.Min();
    }

    private static int FindAnswer(int[][] matrix, int x, int y, Dictionary<string, int> cache)
    {
        if (y < 0 || y > matrix.Length - 1)
        {
            return int.MaxValue;
        }

        if (x == 0)
        {
            return matrix[0][y];
        }

        string cacheKey = $"{x}-{y}";
        if (cache.TryGetValue(cacheKey, out int cachedAnswer))
        {
            return cachedAnswer;
        }

        List<int> possiblePreviousValues = new();
        for (int i = -1; i <= 1; i++)
        {
            string possiblePreviousValueCacheKey = $"{x - 1}-{y + i}";
            int possiblePreviousValue = cache.TryGetValue(possiblePreviousValueCacheKey, out int value)
                ? value
                : FindAnswer(matrix, x - 1, y + i, cache);
            possiblePreviousValues.Add(possiblePreviousValue);
        }

        int answer = possiblePreviousValues.Min() + matrix[x][y];
        cache[cacheKey] = answer;

        return answer;
    }
}
