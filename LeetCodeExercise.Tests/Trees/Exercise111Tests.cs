using LeetCodeExercise.Core.Common;
using LeetCodeExercise.Core.Trees;

namespace LeetCodeExercise.Tests.Trees;

public class Exercise111Tests
{
    [Theory]
    [MemberData(nameof(GetParameters))]
    public void Test(TreeNode? root, int expectedResult)
    {
        int result = Exercise111.MinDepth(root);

        Assert.Equal(expectedResult, result);
    }

    public static IEnumerable<object?[]> GetParameters()
    {
        yield return new object?[]
            { new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))), 2 };
        yield return new object?[] { null, 0 };
    }
}
