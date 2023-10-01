using LeetCodeExercise.Core.Monotonic;

namespace LeetCodeExercise.Tests.Monotonic;

public class Exercise1673Tests
{
    [Theory]
    [InlineData(new int[] { 3, 5, 2, 6 }, 2, new int[] { 2, 6 })]
    [InlineData(new int[] { 2, 4, 3, 3, 5, 4, 9, 6 }, 4, new int[] { 2, 3, 3, 4 })]
    [InlineData(new int[] { 3, 5, 2, 1 }, 2, new int[] { 2, 1 })]
    [InlineData(new int[] { 71, 18, 52, 29, 55, 73, 24, 42, 66, 8, 80, 2 }, 3, new int[] { 8, 80, 2 })]
    public void TestSlow(int[] numbers, int k, int[] expectedResult)
    {
        int[] result = Exercise1673.ExecuteSlow(numbers, k);

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(new int[] { 3, 5, 2, 6 }, 2, new int[] { 2, 6 })]
    [InlineData(new int[] { 2, 4, 3, 3, 5, 4, 9, 6 }, 4, new int[] { 2, 3, 3, 4 })]
    [InlineData(new int[] { 3, 5, 2, 1 }, 2, new int[] { 2, 1 })]
    [InlineData(new int[] { 71, 18, 52, 29, 55, 73, 24, 42, 66, 8, 80, 2 }, 3, new int[] { 8, 80, 2 })]
    public void TestFast(int[] numbers, int k, int[] expectedResult)
    {
        int[] result = Exercise1673.ExecuteFast(numbers, k);

        Assert.Equal(expectedResult, result);
    }
}
