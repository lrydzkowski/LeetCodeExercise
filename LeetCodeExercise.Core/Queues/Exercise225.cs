namespace LeetCodeExercise.Core.Queues;

// https://leetcode.com/problems/implement-stack-using-queues/
public class Exercise225
{
    private readonly Queue<int>[] _queues = { new(), new() };

    public void Push(int x)
    {
        (Queue<int> empty, Queue<int> filled) =
            _queues[0].Count == 0 ? (_queues[0], _queues[1]) : (_queues[1], _queues[0]);
        empty.Enqueue(x);
        while (filled.Count > 0)
        {
            empty.Enqueue(filled.Dequeue());
        }
    }

    public int Pop()
    {
        Queue<int> filled = GetFilledQueue();

        return filled.Dequeue();
    }

    public int Top()
    {
        Queue<int> filled = GetFilledQueue();

        return filled.Peek();
    }

    public bool Empty()
    {
        return _queues[0].Count == 0 && _queues[1].Count == 0;
    }

    private Queue<int> GetFilledQueue()
    {
        Queue<int> filled = _queues[0].Count == 0 ? _queues[1] : _queues[0];
        if (filled.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return filled;
    }
}
