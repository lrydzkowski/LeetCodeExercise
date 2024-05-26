namespace LeetCodeExercise.Core.Other;

public static class Exercise461
{
    public static int HammingDistance(int x, int y)
    {
        int result = x ^ y;
        int response = Convert.ToString(Convert.ToInt32(result.ToString(), 10), 2).ToCharArray().Count(x => x == '1');

        return response;
    }
}
