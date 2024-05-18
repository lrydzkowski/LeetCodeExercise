using LeetCodeExercise.Core.BinarySearch;

namespace LeetCodeExercise.Tests.BinarySearch;

public class Exercise1231Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] sweetness, int k, int expectedResult)
    {
        int result = Exercise1231.MaximizeSweetness(sweetness, k);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            5,
            6
        ];

        yield return
        [
            new[] { 5, 6, 7, 8, 9, 1, 2, 3, 4 },
            8,
            1
        ];

        yield return
        [
            new[] { 1, 2, 2, 1, 2, 2, 1, 2, 2 },
            2,
            5
        ];
    }
}
