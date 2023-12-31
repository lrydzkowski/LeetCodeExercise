namespace LeetCodeExercise.Core.Graphs;

public static class Exercise909
{
    public static int SnakesAndLadders(int[][] board)
    {
        Dictionary<int, int> cellValues = new();
        int cellValue = 1;
        bool fromLeft = true;
        for (int i = board.Length - 1; i >= 0; i--)
        {
            if (fromLeft)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    cellValues[cellValue] = board[i][j];
                    cellValue++;
                }
            }
            else
            {
                for (int j = board[i].Length - 1; j >= 0; j--)
                {
                    cellValues[cellValue] = board[i][j];
                    cellValue++;
                }
            }

            fromLeft = !fromLeft;
        }

        Dictionary<int, bool> seen = new();

        int numOfSteps = 1;
        int goalValue = cellValue - 1;
        Queue<int> elements = new();
        elements.Enqueue(1);
        while (elements.Count > 0)
        {
            int elementsCount = elements.Count;
            for (int i = 0; i < elementsCount; i++)
            {
                int element = elements.Dequeue();
                for (int j = 1; j <= 6; j++)
                {
                    int nextValue = element + j;
                    nextValue = cellValues[nextValue] == -1 ? nextValue : cellValues[nextValue];
                    if (nextValue == goalValue)
                    {
                        return numOfSteps;
                    }

                    if (nextValue > goalValue)
                    {
                        break;
                    }

                    if (!seen.TryAdd(nextValue, true))
                    {
                        continue;
                    }

                    elements.Enqueue(nextValue);
                }
            }

            numOfSteps++;
        }

        return -1;
    }
}
