using LeetCodeExercise.Core.Greedy;

namespace LeetCodeExercise.Tests.Greedy;

public class Exercise1338Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] arr, int expectedResult)
    {
        int result = Exercise1338.MinSetSize(arr);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 },
            2
        ];

        yield return
        [
            new[] { 7, 7, 7, 7, 7, 7 },
            1
        ];
    }
}
