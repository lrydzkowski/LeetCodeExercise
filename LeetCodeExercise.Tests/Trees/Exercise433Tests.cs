using LeetCodeExercise.Core.Graphs;

namespace LeetCodeExercise.Tests.Trees;

public class Exercise433Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(string startGene, string endGene, string[] bank, int expectedResult)
    {
        int result = Exercise433.MinMutation(startGene, endGene, bank);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            "AACCGGTT",
            "AACCGGTA",
            new[] { "AACCGGTA" },
            1
        ];

        yield return
        [
            "AACCGGTT",
            "AAACGGTA",
            new[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" },
            2
        ];

        yield return
        [
            "AACCGGTT",
            "AACCGGTA",
            Array.Empty<string>(),
            -1
        ];
    }
}
