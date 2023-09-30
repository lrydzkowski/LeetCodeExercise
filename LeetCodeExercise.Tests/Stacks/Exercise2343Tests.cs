using LeetCodeExercise.Core.Stacks;

namespace LeetCodeExercise.Tests.Stacks;

public class Exercise2343Tests
{
    [Theory]
    [InlineData("zza", "azz")]
    [InlineData("bac", "abc")]
    [InlineData("bdda", "addb")]
    public void Test(string param, string expectedResult)
    {
        string result = Exercise2434.RobotWithString(param);

        Assert.Equal(expectedResult, result);
    }
}
