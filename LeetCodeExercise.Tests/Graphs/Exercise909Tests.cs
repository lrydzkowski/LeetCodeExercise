using LeetCodeExercise.Core.Graphs;

namespace LeetCodeExercise.Tests.Graphs;

public class Exercise909Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] board, int expectedResult)
    {
        int result = Exercise909.SnakesAndLadders(board);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return new object[]
        {
            new[]
            {
                new[] { -1, -1, -1, -1, -1, -1 },
                new[] { -1, -1, -1, -1, -1, -1 },
                new[] { -1, -1, -1, -1, -1, -1 },
                new[] { -1, 35, -1, -1, 13, -1 },
                new[] { -1, -1, -1, -1, -1, -1 },
                new[] { -1, 15, -1, -1, -1, -1 }
            },
            4
        };

        yield return new object[]
        {
            new[]
            {
                new[] { 1, 1, -1 },
                new[] { 1, 1, 1 },
                new[] { -1, 1, 1 }
            },
            -1
        };
    }
}
