using LeetCodeExercise.Core.Other;

namespace LeetCodeExercise.Tests.Other;

public class Exercise787Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(int n, int[][] flights, int src, int dest, int k, int expectedResult)
    {
        int result = Exercise787.FindCheapestPrice(n, flights, src, dest, k);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return
        [
            4,
            new int[][]
            {
                new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 2, 0, 100 }, new int[] { 1, 3, 600 },
                new int[] { 2, 3, 200 }
            },
            0,
            3,
            1,
            700
        ];

        yield return
        [
            3,
            new int[][]
            {
                new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 }
            },
            0,
            2,
            1,
            200
        ];

        yield return
        [
            3,
            new int[][]
            {
                new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 }
            },
            0,
            2,
            0,
            500
        ];

        yield return
        [
            2,
            new int[][]
            {
                new int[] { 0, 1, 2 }
            },
            1,
            0,
            0,
            -1
        ];

        yield return
        [
            4,
            new int[][]
            {
                new int[] { 0, 1, 1 }, new int[] { 0, 2, 5 }, new int[] { 1, 2, 1 }, new int[] { 2, 3, 1 }
            },
            0,
            3,
            1,
            6
        ];

        yield return
        [
            5,
            new int[][]
            {
                new int[] { 0, 1, 5 }, new int[] { 1, 2, 5 }, new int[] { 0, 3, 2 }, new int[] { 3, 1, 2 },
                new int[] { 1, 4, 1 }, new int[] { 4, 2, 1 }
            },
            0,
            2,
            2,
            7
        ];
    }
}
