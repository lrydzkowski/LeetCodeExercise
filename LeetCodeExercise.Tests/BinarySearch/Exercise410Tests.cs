using LeetCodeExercise.Core.BinarySearch;

namespace LeetCodeExercise.Tests.BinarySearch;

public class Exercise410Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] nums, int k, int expectedResult)
    {
        int result = Exercise410.SplitArray(nums, k);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 7, 2, 5, 10, 8 },
            2,
            18
        ];

        yield return
        [
            new[] { 1, 2, 3, 4, 5 },
            2,
            9
        ];

        yield return
        [
            new[] { 1, 2, 3, 4, 5 },
            1,
            15
        ];

        yield return
        [
            new[] { 10, 5, 13, 4, 8, 4, 5, 11, 14, 9, 16, 10, 20, 8 },
            8,
            25
        ];

        yield return
        [
            new[] { 1, 4, 4 },
            3,
            4
        ];

        yield return
        [
            new[] { 5, 2, 4, 1, 3, 6, 0 },
            4,
            6
        ];
    }
}
