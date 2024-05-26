namespace LeetCodeExercise.Core.DynamicProgramming;

public static class Exercise309
{
    public static int MaxProfit(int[] prices)
    {
        return FindAnswer(prices, false, false, 0, new Dictionary<int, Dictionary<string, int>>());
    }

    private static int FindAnswer(
        int[] prices,
        bool owns,
        bool coolDown,
        int index,
        Dictionary<int, Dictionary<string, int>> cache
    )
    {
        if (index == prices.Length)
        {
            return 0;
        }

        if (!cache.ContainsKey(index))
        {
            cache[index] = new Dictionary<string, int>();
        }

        string cacheKey = $"{owns}-{coolDown}";
        if (cache[index].ContainsKey(cacheKey))
        {
            return cache[index][cacheKey];
        }

        int ans = FindAnswer(prices, owns, false, index + 1, cache);
        if (!coolDown)
        {
            ans = owns
                ? Math.Max(ans, FindAnswer(prices, false, true, index + 1, cache) + prices[index])
                : Math.Max(ans, FindAnswer(prices, true, false, index + 1, cache) - prices[index]);
        }

        cache[index][cacheKey] = ans;

        return ans;
    }
}
