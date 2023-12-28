using LeetCodeExercise.Core.Graphs;

namespace LeetCodeExercise.Tests.Graphs;

public class Exercise1926Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(char[][] maze, int[] entrance, int expectedResult)
    {
        int result = Exercise1926.FindNearestExit(maze, entrance);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return new object[]
        {
            new[]
            {
                new[] { '+', '.', '+', '+', '+', '+', '+' },
                new[] { '+', '.', '+', '.', '.', '.', '+' },
                new[] { '+', '.', '+', '.', '+', '.', '+' },
                new[] { '+', '.', '.', '.', '+', '.', '+' },
                new[] { '+', '+', '+', '+', '+', '.', '+' }
            },
            new[] { 0, 1 },
            12
        };

        yield return new object[]
        {
            new[]
            {
                new[] { '+', '.', '+', '+', '+', '+', '+' },
                new[] { '+', '.', '+', '.', '.', '.', '+' },
                new[] { '+', '.', '+', '.', '+', '.', '+' },
                new[] { '+', '.', '.', '.', '.', '.', '+' },
                new[] { '+', '+', '+', '+', '.', '+', '.' }
            },
            new[] { 0, 1 },
            7
        };

        yield return new object[]
        {
            new[]
            {
                new[] { '+', '.', '+', '+', '+', '+', '+' },
                new[] { '+', '.', '+', '.', '.', '.', '+' },
                new[] { '+', '.', '+', '.', '+', '.', '+' },
                new[] { '+', '.', '.', '.', '+', '.', '+' },
                new[] { '+', '+', '+', '+', '+', '.', '+' }
            },
            new[] { 3, 2 },
            4
        };
    }
}
