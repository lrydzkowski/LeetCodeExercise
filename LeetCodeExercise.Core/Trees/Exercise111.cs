namespace LeetCodeExercise.Core.Trees;

public static class Exercise111
{
    public static int MinDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        int min = FindMinDepth(root);

        return min;
    }

    private static int FindMinDepth(TreeNode? node, int current = 0, int min = int.MaxValue)
    {
        if (node == null)
        {
            return min;
        }

        current++;

        if (node.Left == null && node.Right == null)
        {
            min = Math.Min(current, min);

            return min;
        }

        int leftMin = FindMinDepth(node.Left, current, min);
        int rightMin = FindMinDepth(node.Right, current, min);

        return Math.Min(leftMin, rightMin);
    }
}

public class TreeNode
{
    public int Val { get; }
    public TreeNode? Left { get; }
    public TreeNode? Right { get; }

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }
}
