namespace LeetCodeExercise.Core.Stacks;

// https://leetcode.com/problems/implement-queue-using-stacks/description/
public class Exercise232
{
    private readonly Stack<int>[] _stacks = { new(), new() };

    public void Push(int x)
    {
        while (_stacks[1].Count > 0)
        {
            _stacks[0].Push(_stacks[1].Pop());
        }

        _stacks[1].Push(x);
        while (_stacks[0].Count > 0)
        {
            _stacks[1].Push(_stacks[0].Pop());
        }
    }

    public int Pop()
    {
        if (_stacks[1].Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return _stacks[1].Pop();
    }

    public int Peek()
    {
        if (_stacks[1].Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return _stacks[1].Peek();
    }

    public bool Empty()
    {
        return _stacks[1].Count == 0;
    }
}
