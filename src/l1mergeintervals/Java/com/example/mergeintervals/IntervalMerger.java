package com.example.mergeintervals;

import java.util.ArrayList;
import java.util.List;

public class IntervalMerger {
    public static int[][] mergeIntervals(int[][] intervals) {
        if (intervals.length == 0) {
            return new int[0][];
        }

        List<int[]> result = new ArrayList<>();
        result.add(intervals[0]);

        for (int i = 1; i < intervals.length; i++) {
            int[] lastAddedInterval = result.get(result.size() - 1);
            int[] currentInterval = intervals[i];
            int curStart = currentInterval[0];
            int curEnd = currentInterval[1];

            if (lastAddedInterval[1] >= curStart) {
                lastAddedInterval[1] = Math.max(lastAddedInterval[1], curEnd);
            } else {
                result.add(currentInterval);
            }
        }

        return result.toArray(new int[result.size()][]);
    }
}
