using LeetCodeExercise.Core.Hashing;

namespace LeetCodeExercise.Tests.Hashing;

public class Exercise525Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] numbers, int expectedResult)
    {
        int result = Exercise525.FindMaxLength2(numbers);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 0, 1 },
            2
        ];

        yield return
        [
            new[] { 0, 1, 0 },
            2
        ];

        yield return
        [
            new[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            0
        ];
    }
}
