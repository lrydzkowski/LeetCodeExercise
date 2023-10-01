namespace LeetCodeExercise.Core.Other;

// <https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/>
public class Exercise1475
{
    public static int[] Execute(int[] prices)
    {
        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    prices[i] -= prices[j];

                    break;
                }
            }
        }

        return prices;
    }
}
