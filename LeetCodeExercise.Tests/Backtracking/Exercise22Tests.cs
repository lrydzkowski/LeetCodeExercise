using LeetCodeExercise.Core.Backtracking;

namespace LeetCodeExercise.Tests.Backtracking;

public class Exercise22Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int n, IList<string> expectedResult)
    {
        IList<string> result = Exercise22.GenerateParenthesis(n);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            3,
            new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" }
        ];

        yield return
        [
            1,
            new List<string> { "()" }
        ];
    }
}
