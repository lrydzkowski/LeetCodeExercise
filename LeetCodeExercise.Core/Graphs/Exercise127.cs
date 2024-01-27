namespace LeetCodeExercise.Core.Graphs;

public static class Exercise127
{
    public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        int index = wordList.IndexOf(beginWord);
        if (index == -1)
        {
            wordList.Insert(0, beginWord);
            index = 0;
        }

        List<List<int>> graph = BuildGraph(wordList, new List<List<int>>());
        Dictionary<int, bool> seen = new();
        int steps = FindWord(index, graph, wordList, seen, endWord);

        return steps;
    }

    private static List<List<int>> BuildGraph(IList<string> words, List<List<int>> graph)
    {
        foreach (string word in words)
        {
            List<int> children = new();
            for (int i = 0; i < words.Count; i++)
            {
                string wordToCompare = words[i];
                if (word == wordToCompare)
                {
                    continue;
                }

                if (IsChild(word, wordToCompare))
                {
                    children.Add(i);
                }
            }

            graph.Add(children);
        }

        return graph;
    }

    private static bool IsChild(string parent, string word)
    {
        int numberOfDifferences = 0;
        for (int i = 0; i < parent.Length; i++)
        {
            if (parent[i] != word[i])
            {
                numberOfDifferences++;
            }

            if (numberOfDifferences > 1)
            {
                return false;
            }
        }

        return true;
    }

    private static int FindWord(
        int index,
        List<List<int>> graph,
        IList<string> words,
        Dictionary<int, bool> seen,
        string wordToFind
    )
    {
        Queue<int> indexes = new();
        indexes.Enqueue(index);
        int steps = 0;

        while (indexes.Count > 0)
        {
            steps++;

            int indexesCount = indexes.Count;
            for (int i = 0; i < indexesCount; i++)
            {
                int nextIndex = indexes.Dequeue();
                if (!seen.TryAdd(nextIndex, true))
                {
                    continue;
                }

                if (words[nextIndex] == wordToFind)
                {
                    return steps;
                }

                foreach (int childIndex in graph[nextIndex])
                {
                    indexes.Enqueue(childIndex);
                }
            }
        }

        return 0;
    }
}
