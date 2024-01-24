using LeetCodeExercise.Core.Graphs;

namespace LeetCodeExercise.Tests.Graphs;

public class Exercise2101Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] bombs, int expectedResult)
    {
        int result = Exercise2101.MaximumDetonation(bombs);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[]
            {
                new[] { 2, 1, 3 },
                new[] { 6, 1, 4 }
            },
            2
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 1, 5 },
                new[] { 10, 10, 5 }
            },
            1
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 2, 3 },
                new[] { 2, 3, 1 },
                new[] { 3, 4, 2 },
                new[] { 4, 5, 3 },
                new[] { 5, 6, 4 }
            },
            5
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 1, 100000 },
                new[] { 100000, 100000, 1 }
            },
            1
        ];

        yield return
        [
            new[]
            {
                new[] { 7, 26, 7 },
                new[] { 7, 18, 4 },
                new[] { 3, 10, 7 },
                new[] { 17, 50, 1 },
                new[] { 3, 25, 10 },
                new[] { 85, 23, 8 },
                new[] { 80, 50, 1 },
                new[] { 58, 74, 1 },
                new[] { 38, 39, 7 },
                new[] { 50, 51, 8 },
                new[] { 31, 99, 3 },
                new[] { 53, 6, 5 },
                new[] { 59, 27, 10 },
                new[] { 87, 78, 9 },
                new[] { 68, 58, 3 }
            },
            3
        ];
    }
}
