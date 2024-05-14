using LeetCodeExercise.Core.Greedy;

namespace LeetCodeExercise.Tests.Greedy;

public class Exercise1710Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] boxTypes, int trucSize, int expectedResult)
    {
        int result = Exercise1710.MaximumUnits(boxTypes, trucSize);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { new[] { 1, 3 }, new[] { 2, 2 }, new[] { 3, 1 } },
            4,
            8
        ];

        yield return
        [
            new[] { new[] { 5, 10 }, new[] { 2, 5 }, new[] { 4, 7 }, new[] { 3, 9 } },
            10,
            91
        ];

        yield return
        [
            new[]
            {
                new[] { 1, 3 }, new[] { 5, 5 }, new[] { 2, 5 }, new[] { 4, 2 }, new[] { 4, 1 }, new[] { 3, 1 },
                new[] { 2, 2 }, new[] { 1, 3 }, new[] { 2, 5 }, new[] { 3, 2 }
            },
            35,
            76
        ];
    }
}
