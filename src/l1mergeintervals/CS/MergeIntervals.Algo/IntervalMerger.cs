using System.Collections.Generic;

namespace MergeIntervals.Algo;

public static class IntervalMerger
{
    public static List<int[]> MergeIntervals(List<int[]> intervals)
    {
        if (intervals.Count == 0)
        {
            return new List<int[]>();
        }

        var result = new List<int[]>
        {
            intervals[0]
        };

        for (int i = 1; i < intervals.Count; i++)
        {
            var lastAddedInterval = result[^1];
            var currentInterval = intervals[i];
            var curStart = currentInterval[0];
            var curEnd = currentInterval[1];

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
