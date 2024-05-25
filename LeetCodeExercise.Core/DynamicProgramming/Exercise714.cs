namespace LeetCodeExercise.Core.DynamicProgramming;

public static class Exercise714
{
    public static int MaxProfit(int[] prices, int fee)
    {
        return FindAnswer(prices, fee, false, 0, new Dictionary<int, Dictionary<int, int>>());
    }

    private static int FindAnswer(
        int[] prices,
        int fee,
        bool owns,
        int index,
        Dictionary<int, Dictionary<int, int>> cache
    )
    {
        if (index == prices.Length)
        {
            return 0;
        }

        if (!cache.ContainsKey(index))
        {
            cache[index] = new Dictionary<int, int>();
        }

        if (cache[index].ContainsKey(owns ? 1 : 0))
        {
            return cache[index][owns ? 1 : 0];
        }

        int ans = FindAnswer(prices, fee, owns, index + 1, cache);
        ans = owns
            ? Math.Max(ans, FindAnswer(prices, fee, false, index + 1, cache) + prices[index])
            : Math.Max(ans, FindAnswer(prices, fee, true, index + 1, cache) - fee - prices[index]);
        cache[index][owns ? 1 : 0] = ans;

        return ans;
    }
}
