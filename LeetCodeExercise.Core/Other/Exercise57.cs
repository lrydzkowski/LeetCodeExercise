namespace LeetCodeExercise.Core.Other;

public static class Exercise57
{
    public static int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> updatedIntervals = new();
        if (intervals.Length == 0)
        {
            updatedIntervals.Add(newInterval);

            return updatedIntervals.ToArray();
        }

        if (newInterval[1] < intervals[0][0])
        {
            updatedIntervals.Add(newInterval);
            updatedIntervals.AddRange(intervals);

            return updatedIntervals.ToArray();
        }

        for (int i = 0; i < intervals.Length; i++)
        {
            int start = intervals[i][0];
            int end = intervals[i][1];
            if (i == 0)
            {
                if (newInterval[0] < start)
                {
                    start = newInterval[0];
                }

                if (newInterval[0] <= end && newInterval[1] > end)
                {
                    end = newInterval[1];
                }

                updatedIntervals.Add([start, end]);

                continue;
            }

            int previousIndex = updatedIntervals.Count - 1;
            if (newInterval[0] > updatedIntervals[previousIndex][1]
                && newInterval[0] < intervals[i][0]
                && newInterval[1] > intervals[i][0])
            {
                start = newInterval[0];
            }

            if (newInterval[0] <= end && newInterval[1] > end)
            {
                end = newInterval[1];
            }

            if (updatedIntervals[previousIndex][1] >= start)
            {
                updatedIntervals[previousIndex][1] = end;

                continue;
            }

            if (newInterval[0] > updatedIntervals[previousIndex][1] && newInterval[1] < intervals[i][0])
            {
                updatedIntervals.Add(newInterval);
            }

            updatedIntervals.Add([start, end]);
        }

        if (updatedIntervals.Count <= 0)
        {
            return updatedIntervals.ToArray();
        }

        if (newInterval[0] <= updatedIntervals[^1][1] && newInterval[1] > updatedIntervals[^1][1])
        {
            updatedIntervals[^1][1] = newInterval[1];
        }
        else if (newInterval[0] > updatedIntervals[^1][1] && newInterval[1] > updatedIntervals[^1][1])
        {
            updatedIntervals.Add(newInterval);
        }

        return updatedIntervals.ToArray();
    }
}
