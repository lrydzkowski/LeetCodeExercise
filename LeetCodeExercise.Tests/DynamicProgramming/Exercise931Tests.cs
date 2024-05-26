using LeetCodeExercise.Core.DynamicProgramming;

namespace LeetCodeExercise.Tests.DynamicProgramming;

public class Exercise931Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] matrix, int expectedResult)
    {
        int result = Exercise931.MinFallingPathSum(matrix);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { new[] { 2, 1, 3 }, new[] { 6, 5, 4 }, new[] { 7, 8, 9 } },
            13
        ];

        yield return
        [
            new[] { new[] { -19, 57 }, new[] { -40, -5 } },
            -59
        ];
    }
}
