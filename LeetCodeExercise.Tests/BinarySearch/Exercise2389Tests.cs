using LeetCodeExercise.Core.BinarySearch;

namespace LeetCodeExercise.Tests.BinarySearch;

public class Exercise2389Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] nums, int[] queries, int[] expectedResult)
    {
        int[] result = Exercise2389.AnswerQueries(nums, queries);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 4, 5, 2, 1 },
            new[] { 3, 10, 21 },
            new[] { 2, 3, 4 }
        ];
    }
}
