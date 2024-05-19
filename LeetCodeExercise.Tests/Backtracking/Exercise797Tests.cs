using LeetCodeExercise.Core.Backtracking;

namespace LeetCodeExercise.Tests.Backtracking;

public class Exercise797Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] graph, List<List<int>> expectedResult)
    {
        IList<IList<int>> result = Exercise797.AllPathsSourceTarget(graph);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { new[] { 1, 2 }, new[] { 3 }, new[] { 3 }, [] },
            new List<List<int>>
            {
                new() { 0, 1, 3 },
                new() { 0, 2, 3 }
            }
        ];

        yield return
        [
            new[] { new[] { 4, 3, 1 }, new[] { 3, 2, 4 }, new[] { 3 }, new[] { 4 }, [] },
            new List<List<int>>
            {
                new() { 0, 4 },
                new() { 0, 3, 4 },
                new() { 0, 1, 3, 4 },
                new() { 0, 1, 2, 3, 4 },
                new() { 0, 1, 4 }
            }
        ];
    }
}
