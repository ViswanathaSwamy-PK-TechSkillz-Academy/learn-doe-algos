using MergeIntervals.Algo;

List<List<int[]>> inputList =
[
                [[1, 5], [3, 7], [4, 6]],
                [[1, 5], [4, 6], [6, 8], [11, 15]],
                [[3, 7], [6, 8], [10, 12], [11, 15]],
                [[1, 5]],
                [[1, 9], [3, 8], [4, 4]],
                [[1, 2], [3, 4], [8, 8]],
                [[1, 5], [1, 3]],
                [[1, 5], [6, 9]],
                [[0, 0], [1, 18], [1, 3]]
            ];

foreach (var intervals in inputList)
{
    WriteLine($"Intervals to merge: {string.Join(", ", intervals.Select(i => $"[{i[0]}, {i[1]}]"))}");
    var result = IntervalMerger.MergeIntervals(intervals);
    WriteLine($"Merged intervals: {string.Join(", ", result.Select(i => $"[{i[0]}, {i[1]}]"))}");
    WriteLine(new string('-', 100));
}