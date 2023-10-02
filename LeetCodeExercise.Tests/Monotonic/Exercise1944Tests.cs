using LeetCodeExercise.Core.Monotonic;

namespace LeetCodeExercise.Tests.Monotonic;

public class Exercise1944Tests
{
    [Theory]
    [InlineData(new[] { 10, 6, 8, 5, 11, 9 }, new[] { 3, 1, 2, 1, 1, 0 })]
    [InlineData(new[] { 5, 1, 2, 3, 10 }, new[] { 4, 1, 1, 1, 0 })]
    public void TestSlow(int[] heights, int[] expectedResult)
    {
        int[] result = Exercise1944.RunSlow(heights);

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(new[] { 10, 6, 8, 5, 11, 9 }, new[] { 3, 1, 2, 1, 1, 0 })]
    [InlineData(new[] { 5, 1, 2, 3, 10 }, new[] { 4, 1, 1, 1, 0 })]
    public void TestSlow2(int[] heights, int[] expectedResult)
    {
        int[] result = Exercise1944.RunSlow2(heights);

        Assert.Equal(expectedResult, result);
    }
}
