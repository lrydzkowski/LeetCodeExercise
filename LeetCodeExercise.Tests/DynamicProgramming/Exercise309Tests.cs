using LeetCodeExercise.Core.DynamicProgramming;

namespace LeetCodeExercise.Tests.DynamicProgramming;

public class Exercise309Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] prices, int expectedResult)
    {
        int result = Exercise309.MaxProfit(prices);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 1, 2, 3, 0, 2 },
            3
        ];

        yield return
        [
            new[] { 1 },
            0
        ];

        yield return
        [
            new[] { 1, 2, 4 },
            3
        ];
    }
}
