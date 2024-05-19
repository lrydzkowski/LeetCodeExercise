namespace LeetCodeExercise.Core.Backtracking;

public static class Exercise17
{
    public static IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }

        Dictionary<int, List<char>> dict = new()
        {
            [2] = ['a', 'b', 'c'],
            [3] = ['d', 'e', 'f'],
            [4] = ['g', 'h', 'i'],
            [5] = ['j', 'k', 'l'],
            [6] = ['m', 'n', 'o'],
            [7] = ['p', 'q', 'r', 's'],
            [8] = ['t', 'u', 'v'],
            [9] = ['w', 'x', 'y', 'z']
        };
        List<string> answers = GoThroughGraph(
            dict,
            digits.Select(ToInt).ToArray(),
            0,
            new List<char>(),
            new List<string>()
        );

        return answers;
    }

    private static List<string> GoThroughGraph(
        Dictionary<int, List<char>> dict,
        int[] digits,
        int index,
        List<char> path,
        List<string> answers
    )
    {
        if (digits.Length == index)
        {
            answers.Add(string.Join("", path));

            return answers;
        }

        int digit = digits[index];
        foreach (char character in dict[digit])
        {
            path.Add(character);
            answers = GoThroughGraph(dict, digits, index + 1, path, answers);
            path.RemoveAt(path.Count - 1);
        }

        return answers;
    }

    private static int ToInt(this char c)
    {
        return (int)(c - '0');
    }
}
