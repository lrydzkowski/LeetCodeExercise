using LeetCodeExercise.Core.BinarySearch;

namespace LeetCodeExercise.Tests.BinarySearch;

public class Exercise1283Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] nums, int threshold, int expectedResult)
    {
        int result = Exercise1283.SmallestDivisor(nums, threshold);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 1, 2, 5, 9 },
            6,
            5
        ];

        yield return
        [
            new[] { 44, 22, 33, 11, 1 },
            5,
            44
        ];
    }
}
