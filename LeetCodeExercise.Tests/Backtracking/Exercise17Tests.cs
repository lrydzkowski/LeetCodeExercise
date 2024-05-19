using LeetCodeExercise.Core.Backtracking;

namespace LeetCodeExercise.Tests.Backtracking;

public class Exercise17Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(string digits, IList<string> expectedResult)
    {
        IList<string> result = Exercise17.LetterCombinations(digits);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            "23",
            new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }
        ];

        yield return
        [
            "",
            new List<string>()
        ];

        yield return
        [
            "2",
            new List<string>() { "a", "b", "c" }
        ];
    }
}
