using LeetCodeExercise.Core.Queues;

namespace LeetCodeExercise.Tests.Queues;

public class Exercise225Tests
{
    [Fact]
    public void Test()
    {
        Exercise225 exercise = new();
        exercise.Push(1);
        exercise.Push(2);

        Assert.Equal(2, exercise.Top());
        Assert.Equal(2, exercise.Pop());
        Assert.False(exercise.Empty());
    }
}
