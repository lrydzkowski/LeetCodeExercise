using LeetCodeExercise.Core.Common;

namespace LeetCodeExercise.Core.Trees;

public static class Exercise543
{
    public static int DiameterOfBinaryTree(TreeNode? root)
    {
        int diameter = FindDiameter(root);

        return diameter;
    }

    private static int FindDiameter(TreeNode? root, int diameter = 0)
    {
        if (root == null)
        {
            return diameter;
        }

        int currentDiameter = FindDepth(root.Left) + FindDepth(root.Right);
        diameter = Math.Max(diameter, currentDiameter);

        diameter = FindDiameter(root.Left, diameter);
        diameter = FindDiameter(root.Right, diameter);

        return diameter;
    }

    private static int FindDepth(TreeNode? root, int depth = 0)
    {
        if (root == null)
        {
            return depth;
        }

        depth++;

        int leftDepth = FindDepth(root.Left, depth);
        int rightDepth = FindDepth(root.Right, depth);

        return Math.Max(leftDepth, rightDepth);
    }
}
