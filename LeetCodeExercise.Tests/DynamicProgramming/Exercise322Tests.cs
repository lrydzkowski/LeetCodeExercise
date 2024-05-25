using LeetCodeExercise.Core.DynamicProgramming;

namespace LeetCodeExercise.Tests.DynamicProgramming;

public class Exercise322Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] coins, int amount, int expectedResult)
    {
        int result = Exercise322.CoinChange(coins, amount);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 1, 2, 5 },
            11,
            3
        ];

        yield return
        [
            new[] { 2 },
            3,
            -1
        ];

        yield return
        [
            new[] { 1 },
            0,
            0
        ];
    }
}
