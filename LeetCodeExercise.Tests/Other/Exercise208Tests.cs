using LeetCodeExercise.Core.Other;

namespace LeetCodeExercise.Tests.Other;

public class Exercise208Tests
{
    [Fact]
    public void Test()
    {
        List<bool> expectedResults = [true, false, true, true];
        List<bool> results = new();

        Exercise208 exercise208 = new();
        exercise208.Insert("apple");
        results.Add(exercise208.Search("apple"));
        results.Add(exercise208.Search("app"));
        results.Add(exercise208.StartsWith("app"));
        exercise208.Insert("app");
        results.Add(exercise208.Search("app"));

        Assert.Equal(expectedResults, results);
    }
}
