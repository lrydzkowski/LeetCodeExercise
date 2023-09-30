using System.Text;

namespace LeetCodeExercise.Core.Stacks;

// https://leetcode.com/problems/using-a-robot-to-print-the-lexicographically-smallest-string/
public static class Exercise2434
{
    public static string RobotWithString(string s)
    {
        StringBuilder res = new();
        int n = s.Length;
        char min = 'a';
        char max = 'z';
        int last = 0;
        Stack<char> stack = new();
        for (int cur = min; cur <= max; cur++)
        {
            while (stack.Count > 0 && stack.Peek() < cur)
            {
                res.Append(stack.Pop());
            }

            for (int i = last; i < n; i++)
            {
                if (s[i] != cur)
                {
                    continue;
                }

                for (int j = last; j < i; j++)
                {
                    stack.Push(s[j]);
                }

                res.Append(s[i]);
                last = i + 1;
            }
        }

        while (stack.Count > 0)
        {
            res.Append(stack.Pop());
        }

        return res.ToString();
    }
}
