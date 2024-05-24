namespace LeetCodeExercise.Core.DynamicProgramming;

public static class Exercise746
{
    public static int MinCostClimbingStairs(int[] cost)
    {
        if (cost.Length == 0)
        {
            return 0;
        }

        return Calculate(cost, cost.Length, new Dictionary<int, int>());
    }

    private static int Calculate(int[] cost, int i, Dictionary<int, int> cache)
    {
        if (i <= 1)
        {
            return cost[i];
        }

        if (cache.ContainsKey(i))
        {
            return cache[i];
        }

        int currentCost = i == cost.Length ? 0 : cost[i];
        currentCost = Math.Min(
            Calculate(cost, i - 1, cache) + currentCost,
            Calculate(cost, i - 2, cache) + currentCost
        );
        cache[i] = currentCost;

        return currentCost;
    }
}
