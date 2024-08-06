export function mergeIntervals(intervals: number[][]): number[][] {
    if (intervals.length === 0) {
        return [];
    }

    const result: number[][] = [];
    result.push(intervals[0]);

    for (let i = 1; i < intervals.length; i++) {
        const lastAddedInterval = result[result.length - 1];
        const curStart = intervals[i][0];
        const curEnd = intervals[i][1];

        if (lastAddedInterval[1] >= curStart) {
            lastAddedInterval[1] = Math.max(lastAddedInterval[1], curEnd);
        } else {
            result.push(intervals[i]);
        }
    }

    return result;
}
