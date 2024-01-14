using System.Text;

namespace LeetCodeExercise.Core.Graphs;

public static class Exercise433
{
    private static readonly char[] AllowedCharacters = ['A', 'C', 'G', 'T'];

    public static int MinMutation(string startGene, string endGene, string[] bank)
    {
        HashSet<string> bankSet = [..bank];
        Dictionary<string, bool> visited = new() { [startGene] = true };
        Queue<string> genesToAnalyze = new();
        genesToAnalyze.Enqueue(startGene);
        int steps = 0;
        while (genesToAnalyze.Count > 0)
        {
            int genesToAnalyzeCount = genesToAnalyze.Count;
            for (int i = 0; i < genesToAnalyzeCount; i++)
            {
                string geneToAnalyze = genesToAnalyze.Dequeue();
                if (geneToAnalyze == endGene)
                {
                    return steps;
                }

                AddNextGenesToQueue(geneToAnalyze, bankSet, visited, genesToAnalyze);
            }

            steps++;
        }

        return -1;
    }

    private static void AddNextGenesToQueue(
        string gene,
        HashSet<string> bankSet,
        Dictionary<string, bool> visited,
        Queue<string> genesToAnalyze
    )
    {
        for (int i = 0; i < gene.Length; i++)
        {
            char geneLetter = gene[i];
            foreach (char allowedCharacter in AllowedCharacters)
            {
                if (geneLetter == allowedCharacter)
                {
                    continue;
                }

                StringBuilder newGeneBuilder = new(gene)
                {
                    [i] = allowedCharacter
                };
                string newGene = newGeneBuilder.ToString();
                if (!bankSet.Contains(newGene))
                {
                    continue;
                }

                if (!visited.TryAdd(newGene, true))
                {
                    continue;
                }

                genesToAnalyze.Enqueue(newGene);
            }
        }
    }
}
