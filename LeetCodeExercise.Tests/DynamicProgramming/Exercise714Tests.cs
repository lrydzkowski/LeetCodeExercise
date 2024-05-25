using LeetCodeExercise.Core.DynamicProgramming;

namespace LeetCodeExercise.Tests.DynamicProgramming;

public class Exercise714Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] prices, int fee, int expectedResult)
    {
        int result = Exercise714.MaxProfit(prices, fee);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 1, 3, 2, 8, 4, 9 },
            2,
            8
        ];

        yield return
        [
            new[] { 1, 3, 7, 5, 10, 3 },
            3,
            6
        ];
    }
}
