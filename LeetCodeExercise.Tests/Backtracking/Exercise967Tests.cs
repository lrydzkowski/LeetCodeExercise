using LeetCodeExercise.Core.Backtracking;

namespace LeetCodeExercise.Tests.Backtracking;

public class Exercise967Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int n, int k, int[] expectedResult)
    {
        int[] result = Exercise967.NumsSameConsecDiff(n, k);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            3,
            7,
            new int[] { 181, 292, 707, 818, 929 }
        ];

        yield return
        [
            2,
            1,
            new int[] { 10, 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98 }
        ];

        yield return
        [
            2,
            0,
            new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 }
        ];
    }
}
