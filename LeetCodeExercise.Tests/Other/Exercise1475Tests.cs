using LeetCodeExercise.Core.Other;

namespace LeetCodeExercise.Tests.Other;

public class Exercise1475Tests
{
    [Theory]
    [InlineData(new[] { 8, 4, 6, 2, 3 }, new[] { 4, 2, 4, 2, 3 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 10, 1, 1, 6 }, new[] { 9, 0, 1, 6 })]
    public void Test(int[] prices, int[] expectedResult)
    {
        int[] result = Exercise1475.Execute(prices);

        Assert.Equal(expectedResult, result);
    }
}
