using LeetCodeExercise.Core.DynamicProgramming;

namespace LeetCodeExercise.Tests.DynamicProgramming;

public class Exercise63Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] obstacleGrid, int expectedResult)
    {
        int result = Exercise63.UniquePathsWithObstacles(obstacleGrid);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { new[] { 0, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 0 } },
            2
        ];

        yield return
        [
            new[] { new[] { 0, 1 }, new[] { 0, 0 } },
            1
        ];
    }
}
