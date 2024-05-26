using LeetCodeExercise.Core.Other;

namespace LeetCodeExercise.Tests.Other;

public class Exercise461Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int x, int y, int expectedResult)
    {
        int result = Exercise461.HammingDistance(x, y);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            1,
            4,
            2
        ];

        yield return
        [
            3,
            1,
            1
        ];
    }
}
