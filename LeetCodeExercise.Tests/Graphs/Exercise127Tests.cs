using LeetCodeExercise.Core.Graphs;

namespace LeetCodeExercise.Tests.Graphs;

public class Exercise127Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(string beginWord, string endWord, IList<string> wordList, int expectedResult)
    {
        int result = Exercise127.LadderLength(beginWord, endWord, wordList);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return new object[]
        {
            "hit",
            "cog",
            new List<string> { "hot", "dot", "dog", "lot", "log", "cog" },
            5
        };

        yield return new object[]
        {
            "hit",
            "cog",
            new List<string> { "hot", "dot", "dog", "lot", "log" },
            0
        };

        yield return new object[]
        {
            "a",
            "c",
            new List<string> { "a", "b", "c" },
            2
        };
    }
}
