using LeetCodeExercise.Core.Heaps;

namespace LeetCodeExercise.Tests.Heaps;

public class Exercise215Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[] numbers, int k, int expectedResult)
    {
        int result = Exercise215.FindKthLargest(numbers, k);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new[] { 3, 2, 1, 5, 6, 4 },
            2,
            5
        ];
    }
}
