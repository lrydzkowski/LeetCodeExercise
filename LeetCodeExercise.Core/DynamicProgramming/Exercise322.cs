namespace LeetCodeExercise.Core.DynamicProgramming;

public static class Exercise322
{
    public static int CoinChange(int[] coins, int amount)
    {
        if (amount == 0)
        {
            return 0;
        }

        return FindAnswer(coins, amount, new Dictionary<int, int>());
    }

    private static int FindAnswer(
        int[] coins,
        int amount,
        Dictionary<int, int> cache
    )
    {
        int min = int.MaxValue;
        foreach (int coin in coins)
        {
            if (amount - coin == 0)
            {
                min = 1;

                continue;
            }

            if (amount - coin < 0)
            {
                continue;
            }

            int currentOperations = cache.ContainsKey(amount - coin)
                ? cache[amount - coin]
                : FindAnswer(coins, amount - coin, cache);
            if (currentOperations == -1)
            {
                continue;
            }

            currentOperations += 1;
            min = Math.Min(min, currentOperations);
        }

        int answer = min == int.MaxValue ? -1 : min;
        cache[amount] = answer;

        return answer;
    }
}
