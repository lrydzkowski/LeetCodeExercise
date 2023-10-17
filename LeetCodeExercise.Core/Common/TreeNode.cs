namespace LeetCodeExercise.Core.Common;

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
