using LeetCodeExercise.Core.Heaps;

namespace LeetCodeExercise.Tests.Heaps;

public class Exercise973Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] points, int k, int[][] expectedResult)
    {
        int[][] result = Exercise973.Calculate(points, k);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { new[] { 3, 3 }, new[] { 5, -1 }, new[] { -2, 4 } },
            2,
            new[] { new[] { 3, 3 }, new[] { -2, 4 } }
        ];
    }
}
