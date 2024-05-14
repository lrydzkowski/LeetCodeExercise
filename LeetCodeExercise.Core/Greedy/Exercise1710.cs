namespace LeetCodeExercise.Core.Greedy;

public static class Exercise1710
{
    public static int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        boxTypes = boxTypes.OrderByDescending(x => x[1]).ToArray();
        int response = 0;
        int index = 0;
        for (int i = 0; i < truckSize; i++)
        {
            response += boxTypes[index][1];
            boxTypes[index][0]--;
            if (boxTypes[index][0] == 0)
            {
                index++;
                if (index == boxTypes.Length)
                {
                    break;
                }
            }
        }

        return response;
    }
}
