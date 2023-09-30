using LeetCodeExercise.Core.Stacks;

namespace LeetCodeExercise.Tests.Stacks;

public class Exercise232Tests
{
    [Fact]
    public void Test()
    {
        Exercise232 exercise = new();
        exercise.Push(1);
        exercise.Push(2);

        Assert.Equal(1, exercise.Peek());
        Assert.Equal(1, exercise.Pop());
        Assert.False(exercise.Empty());
    }
}
