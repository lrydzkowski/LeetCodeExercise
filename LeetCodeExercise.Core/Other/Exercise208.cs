namespace LeetCodeExercise.Core.Other;

public class Exercise208
{
    private readonly TieNode _root = new('_');

    public void Insert(string word)
    {
        TieNode current = _root;
        foreach (char c in word)
        {
            TieNode? children = current.Children.FirstOrDefault(x => x.Value == c);
            if (children == null)
            {
                children = new TieNode(c);
                current.Children.Add(children);
            }

            current = children;
        }

        current.Words.Add(word);
    }

    public bool Search(string word)
    {
        TieNode current = _root;
        foreach (char c in word)
        {
            TieNode? children = current.Children.FirstOrDefault(x => x.Value == c);
            if (children == null)
            {
                return false;
            }

            current = children;
        }

        return current.Words.Contains(word);
    }

    public bool StartsWith(string prefix)
    {
        TieNode current = _root;
        foreach (char c in prefix)
        {
            TieNode? children = current.Children.FirstOrDefault(x => x.Value == c);
            if (children == null)
            {
                return false;
            }

            current = children;
        }

        return true;
    }

    private class TieNode
    {
        public char Value { get; set; }

        public List<TieNode> Children { get; set; } = [];

        public List<string> Words { get; set; } = [];

        public TieNode(char value)
        {
            Value = value;
        }
    }
}
