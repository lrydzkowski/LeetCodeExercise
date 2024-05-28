using LeetCodeExercise.Core.Other;

namespace LeetCodeExercise.Tests.Other;

public class Exercise57Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int[][] intervals, int[] newInterval, int[][] expectedResult)
    {
        int[][] result = Exercise57.Insert(intervals, newInterval);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } },
            new int[] { 2, 5 },
            new int[][] { new int[] { 1, 5 }, new int[] { 6, 9 } }
        ];

        yield return
        [
            new int[][]
            {
                new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 }
            },
            new int[] { 4, 8 },
            new int[][] { new int[] { 1, 2 }, new int[] { 3, 10 }, new int[] { 12, 16 } }
        ];

        yield return
        [
            new int[][] { },
            new int[] { 5, 7 },
            new int[][] { new int[] { 5, 7 } }
        ];

        yield return
        [
            new int[][] { new int[] { 1, 5 } },
            new int[] { 5, 7 },
            new int[][] { new int[] { 1, 7 } }
        ];

        yield return
        [
            new int[][] { new int[] { 1, 5 } },
            new int[] { 6, 8 },
            new int[][] { new int[] { 1, 5 }, new int[] { 6, 8 } }
        ];
    }
}
