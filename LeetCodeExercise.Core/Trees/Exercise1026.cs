using LeetCodeExercise.Core.Common;

namespace LeetCodeExercise.Core.Trees;

public static class Exercise1026
{
    public static int MaxAncestorDiff(TreeNode root)
    {
        int max = CalculateMax(root, new List<int>(), 0);

        return max;
    }

    private static int CalculateMax(TreeNode? root, List<int> values, int max)
    {
        if (root == null)
        {
            return max;
        }

        int currentValue = root.Val;
        foreach (int val in values)
        {
            max = Math.Max(max, Math.Abs(currentValue - val));
        }

        values.Add(currentValue);

        max = CalculateMax(root.Left, values, max);
        max = CalculateMax(root.Right, values, max);

        values.RemoveAt(values.Count - 1);

        return max;
    }
}
