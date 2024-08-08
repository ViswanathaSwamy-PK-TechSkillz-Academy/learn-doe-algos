namespace MergeIntervals.Algo;

public static class IntervalMerger
{
    public static List<int[]> MergeIntervals(List<int[]> intervals)
    {
        if (intervals.Count == 0)
        {
            return [];
        }

        List<int[]>? result =
        [
            intervals[0]
        ];

        for (int i = 1; i < intervals.Count; i++)
        {
            int[]? lastAddedInterval = result[^1];
            int[]? currentInterval = intervals[i];
            int curStart = currentInterval[0];
            int curEnd = currentInterval[1];

            if (lastAddedInterval[1] >= curStart)
            {
                lastAddedInterval[1] = System.Math.Max(lastAddedInterval[1], curEnd);
            }
            else
            {
                result.Add(currentInterval);
            }
        }

        return result;
    }
}
