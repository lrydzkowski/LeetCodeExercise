using LeetCodeExercise.Core.Backtracking;

namespace LeetCodeExercise.Tests.Backtracking;

public class Exercise216Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int k, int n, List<List<int>> expectedResult)
    {
        IList<IList<int>> result = Exercise216.CombinationSum3(k, n);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            3,
            7,
            new List<List<int>>
            {
                new() { 1, 2, 4 }
            }
        ];

        yield return
        [
            3,
            9,
            new List<List<int>>
            {
                new() { 1, 2, 6 },
                new() { 1, 3, 5 },
                new() { 2, 3, 4 }
            }
        ];

        yield return
        [
            4,
            1,
            new List<List<int>>()
        ];
    }
}
