using LeetCodeExercise.Core.Common;
using LeetCodeExercise.Core.Trees;

namespace LeetCodeExercise.Tests.Trees;

public class Exercise1026Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(TreeNode root, int expectedResult)
    {
        int result = Exercise1026.MaxAncestorDiff(root);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return new object[]
        {
            new TreeNode(
                8,
                new TreeNode(3, new TreeNode(1), new TreeNode(6, new TreeNode(4), new TreeNode(7))),
                new TreeNode(10, null, new TreeNode(14, new TreeNode(13)))
            ),
            7
        };
    }
}
