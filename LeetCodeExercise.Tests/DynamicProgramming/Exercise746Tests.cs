using LeetCodeExercise.Core.DynamicProgramming;

namespace LeetCodeExercise.Tests.DynamicProgramming;

public class Exercise746Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] cost, int expectedResult)
    {
        int result = Exercise746.MinCostClimbingStairs(cost);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 10, 15, 20 },
            15
        ];

        yield return
        [
            new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 },
            6
        ];
    }
}
