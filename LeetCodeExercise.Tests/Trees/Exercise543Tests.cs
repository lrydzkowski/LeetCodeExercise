using LeetCodeExercise.Core.Common;
using LeetCodeExercise.Core.Trees;

namespace LeetCodeExercise.Tests.Trees;

public class Exercise543Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(TreeNode root, int expectedResult)
    {
        int result = Exercise543.DiameterOfBinaryTree(root);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object[]> GetParameters()
    {
        yield return new object[]
        {
            new TreeNode(
                4,
                new TreeNode(-7),
                new TreeNode(
                    -3,
                    new TreeNode(
                        -9,
                        new TreeNode(
                            9,
                            new TreeNode(6, new TreeNode(0, null, new TreeNode(-1)), new TreeNode(6, new TreeNode(-4)))
                        ),
                        new TreeNode(
                            -7,
                            new TreeNode(-6, new TreeNode(5)),
                            new TreeNode(-6, new TreeNode(9, new TreeNode(-2)))
                        )
                    ),
                    new TreeNode(-3, new TreeNode(-4))
                )
            ),
            8
        };
    }
}
